using Application.Common.Dto.Result;
using Application.Services.CategorySrv.Iface;
using Application.Services.CommonSrv.SearchSrv.Dto;
using Application.Services.CommonSrv.SearchSrv.Iface;
using Application.Services.CompanionSrvs.AssistanceSrv.Iface;
using Application.Services.CompanionSrvs.CompanionSrv.Iface;
using Application.Services.ProductSrvs.BrandSrv.Iface;
using Application.Services.ProductSrvs.FeatureSrv.Iface;
using Application.Services.ProductSrvs.ProductSrv.Iface;
using System.Threading.Tasks;

namespace Application.Services.CommonSrv.SearchSrv
{
    public class SearchService : ISearchService
    {
        private readonly IProductService _productService;
        private readonly IBrandService _brandService;
        private readonly ICategoryService _categoryService;
        private readonly IFeatureItemService _featureItemService;
        private readonly ICompanionService _companionService;
        private readonly IAssistanceService _assistanceService;
        public SearchService(IAssistanceService assistanceService, ICompanionService companionService, IProductService productService, IBrandService brandService, ICategoryService categoryService, IFeatureItemService featureItemService)
        {
            this._productService = productService;
            this._brandService = brandService;
            this._categoryService = categoryService;
            this._featureItemService = featureItemService;
            this._companionService = companionService;
            this._assistanceService = assistanceService;
        }
        public async Task<BaseResultDto<SearchDto>> SearchAsync(SearchRequestDto request)
        {
            var result = new SearchDto();
            if (request.ProductCount > 0)
            {
                result.Products = await _productService.SearchMinAsync(request);
            }
            if (request.CategoryCount > 0)
            {
                result.Categories = await _categoryService.SearchMinAsync(request);
            }
            if (request.BrandCount > 0)
            {
                result.Brands = await _brandService.SearchMinAsync(request);
            }
            if (request.FeatureCount > 0)
            {
                result.Feature = await _featureItemService.SearchMinAsync(request);
            }
            if (request.CompanionCount > 0)
            {
                result.Companions = await _companionService.SearchMinAsync(request);
            }
            if (request.AssistanceCount > 0)
            {
                result.Assistances = await _assistanceService.SearchMinAsync(request);
            }
            return new BaseResultDto<SearchDto>(true, data: result);
        }
    }
}
