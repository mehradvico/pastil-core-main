using AngleSharp.Dom;
using Application.Common.Dto.Result;
using Application.Services.Filing.PictureSrv.Dto;
using Application.Services.Filing.PictureSrv.Iface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats;
using SixLabors.ImageSharp.Formats.Bmp;
using SixLabors.ImageSharp.Formats.Jpeg;
using SixLabors.ImageSharp.Formats.Png;
using SixLabors.ImageSharp.Formats.Webp;
using SixLabors.ImageSharp.Processing;


namespace File.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class PictureUploadController : ControllerBase
    {
        private IPictureService pictureService;
        public PictureUploadController(IPictureService pictureService)
        {
            this.pictureService = pictureService;
        }


        [HttpPost]
        public async Task<IActionResult> Post(IFormFile PictureFile)
        {
            var dic = new Dictionary<string, int>();
            dic.Add("lg", 900);
            dic.Add("md", 500);
            dic.Add("sm", 300);
            const int quality = 85;
            string[] allowPicExtensions = { ".jpg", ".jpeg", ".png", ".bmp", ".webp", ".svg", ".gif" };
            string[] allowVideoExtensions = { ".mp4", ".webm", ".ogg" };
            if (PictureFile.Length > 0)
            {
                var now = DateTime.Now;
                var extension = Path.GetExtension(PictureFile.FileName);
                if (allowPicExtensions.Contains(extension.ToLower()) || allowVideoExtensions.Contains(extension.ToLower()))
                {

                    var orginalName = Path.GetFileName(PictureFile.FileName);
                    var fileName = Guid.NewGuid().ToString().Replace("-", "");
                    string filePath = Path.Combine("wwwroot", "Media", now.Year.ToString(), now.Month.ToString(), now.Day.ToString());
                    if (!Directory.Exists(filePath))
                        Directory.CreateDirectory(filePath);
                    var path = Path.Combine(filePath, fileName + extension);
                    using (var stream = System.IO.File.Create(path))
                    {
                        await PictureFile.CopyToAsync(stream);
                    }
                    if (allowPicExtensions.Contains(extension.ToLower()))
                    {
                        IImageEncoder encoder = new JpegEncoder { Quality = quality };
                        if (extension.ToLower() == ".jpg" || extension.ToLower() == ".jpeg")
                            encoder = new JpegEncoder { Quality = quality };
                        else if (extension.ToLower() == ".bmp")
                            encoder = new BmpEncoder { BitsPerPixel = BmpBitsPerPixel.Pixel24 };
                        else if (extension.ToLower() == ".webp")
                            encoder = new WebpEncoder { Quality = quality };
                        else if (extension.ToLower() == ".png")
                            encoder = new PngEncoder { CompressionLevel = PngCompressionLevel.Level9 };
                        foreach (var item in dic)
                        {
                            using (var image = SixLabors.ImageSharp.Image.Load(path))
                            {

                                int height, width;
                                if (image.Width <= item.Value)
                                {
                                    width = image.Width;
                                    height = image.Height;
                                }
                                else
                                {
                                    width = item.Value;
                                    var a = image.Height / (float)image.Width;
                                    height = (int)(item.Value * a);
                                }
                                image.Mutate(x => x.Resize(width, height));
                                image.Save(Path.Combine(filePath, fileName + "-" + item.Key + extension),
                                    encoder);
                            }
                        }
                    }


                    var pictureDto = new PictureDto()
                    {
                        Size = PictureFile.Length,
                        ContentType = PictureFile.ContentType,
                        CreateDate = now,
                        Extension = extension,
                        Name = fileName + extension,
                        GuidName = fileName,
                        Url = filePath.Replace("wwwroot", "").Replace("\\", "/"),
                        OrginalName = orginalName
                    };
                    var result = await pictureService.InsertAsyncDto(pictureDto);
                    return Ok(result);
                }
                else
                {
                    return Ok(new BaseResultDto(isSuccess: false, val: Resource.Notification.FileNotAllow));

                }
            }
            return Ok(new BaseResultDto(isSuccess: false, val: Resource.Notification.Unsuccess));
        }
        [HttpPut]
        public IActionResult Put()
        {
            try
            {
                var dic = new Dictionary<string, int>();
                dic.Add("lg", 900);
                dic.Add("md", 500);
                dic.Add("sm", 300);
                const int quality = 85;
                var allPictures = pictureService.GetAll();
                foreach (var pic in allPictures)
                {

                    if (pic.Extension.ToLower() == ".jpg" || pic.Extension.ToLower() == ".jpeg" || pic.Extension.ToLower() == ".png" || pic.Extension.ToLower() == ".bmp" || pic.Extension.ToLower() == ".webp" || pic.Extension.ToLower() == ".svg")
                        foreach (var item in dic)
                        {
                            IImageEncoder encoder = new JpegEncoder { Quality = quality };
                            if (pic.Extension.ToLower() == ".jpg" || pic.Extension.ToLower() == ".jpeg")
                                encoder = new JpegEncoder { Quality = quality };
                            else if (pic.Extension.ToLower() == ".bmp")
                                encoder = new BmpEncoder { BitsPerPixel = BmpBitsPerPixel.Pixel24 };
                            else if (pic.Extension.ToLower() == ".webp")
                                encoder = new WebpEncoder { Quality = quality };
                            else if (pic.Extension.ToLower() == ".png")
                                encoder = new PngEncoder { CompressionLevel = PngCompressionLevel.Level9 };
                            var path = Path.Combine(pic.Url.Replace("/", "\\") + "\\" + pic.Name);
                            path = "wwwroot" + path;
                            if (System.IO.File.Exists(path))
                                using (var image = SixLabors.ImageSharp.Image.Load(Path.Combine(path)))
                                {
                                    int height, width;
                                    if (image.Width <= item.Value)
                                    {
                                        width = image.Width;
                                        height = image.Height;
                                    }
                                    else
                                    {
                                        width = item.Value;
                                        var a = image.Height / (float)image.Width;
                                        height = (int)(item.Value * a);
                                    }
                                    var picname = pic.Name.Split('.')[0] + "-" + item.Key + pic.Extension;

                                    image.Mutate(x => x.Resize(width, height));
                                    var newPath = Path.Combine("wwwroot", pic.Url.Replace("/", "\\") + "\\" + picname);
                                    newPath = "wwwroot" + newPath;

                                    if (System.IO.File.Exists(newPath))
                                    {
                                        System.IO.File.Delete(newPath);
                                    }
                                    image.Save(newPath,
                                    encoder);
                                }
                        }
                }
                return Ok();
            }
            catch
            {
                return Ok(new BaseResultDto(isSuccess: false, val: Resource.Notification.Unsuccess));

            }


        }

    }
}
