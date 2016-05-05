 var app = angular.module("app", ["ngRoute"])
  .config(function ($routeProvider) {
      $routeProvider
      .when("/", {
          controller: "HomeController.cs",
          templateUrl:
          "/Views/Index.cshtml"
      })
      .when("/Login.html", {
          controller: "AuthController.cs",
          templateUrl:
          "/Views/Login.cshtml"
      })
      .otherwise({ redirectTo: "/" });
  });
 //Been going nuts with angular trying to map this out when suddenly its now 11:30. Dont have enough time to go through all of it mvc-wise. So i'm just going to keep fixing errors and such and 
 //possibly trying to publish to azure if I can in the next half hour or so. 
