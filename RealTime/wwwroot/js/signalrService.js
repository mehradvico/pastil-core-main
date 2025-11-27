var connection = new signalR.HubConnectionBuilder()
    //.withUrl("https://pastil-realtime.bhptest.ir/driverHub", {

    .withUrl("https://localhost:7215/driverHub", {
        accessTokenFactory: function () {
            // در اینجا باید توکن ذخیره شده را برگردانید
            return 'eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJVc2VySWQiOiI2OCIsIkZpcnN0TmFtZSI6ItmF2LHYqti224wiLCJMYXN0TmFtZSI6Itiy2YbYryIsIlJvbGVJZCI6IjIiLCJuYmYiOjE3Mzg2NzA1NTUsImV4cCI6MTczOTEwMjU1NSwiaXNzIjoicGFzdGlsLmNvbSIsImF1ZCI6InBhc3RpbC5jb20ifQ.txouMobMRHNhcJN8ObsWNIU_kIoy80_Eg-KHf3lNlXY';  // یا به هر روشی که توکن ذخیره شده باشد
        }
    })
    .build();
connection.start()
    .then(function () {
        console.log("Connection established!");
    })
    .catch(function (err) {
        console.error("Error while establishing connection: ", err.toString());
    });

document.getElementById("joinButton").addEventListener("click", function () {
    debugger
    var tripDto = {
        origin: {
            x: 35.748468043869686,
            y: 51.37943442595698
        },
        destination: {
            x: 35.74872744027782,
            y: 51.37864974152506
        },
        stopTime: 10,
        roundTrip: true
    };

    connection.invoke("JoinPassenger", tripDto)
        .then(function () {
            console.log("Passenger joined successfully");
        })
        .catch(function (err) {
            debugger
            console.error("Error during join passenger: ", err.toString());
        });
});

// Listen to the message from the server when the passenger joins
connection.on("PassengerJoined", function (tripDto) {
    console.log("Passenger joined: ", tripDto);
});

//سینا : eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJVc2VySWQiOiIxMDciLCJGaXJzdE5hbWUiOiLYs9uM2YbYpyAiLCJMYXN0TmFtZSI6Iti12KfYr9mC24wiLCJSb2xlSWQiOiIxIiwibmJmIjoxNzM4NjgxNzY4LCJleHAiOjE3MzkxMTM3NjgsImlzcyI6InBhc3RpbC5jb20iLCJhdWQiOiJwYXN0aWwuY29tIn0.fHA3rwyCP2eyisDiWrOgUPODWZqfkux6D33vGZTT5w4
