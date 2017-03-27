angular.module('dbService', ['ngResource'])
  .factory('dbService', ['$resource', '$rootScope', function (resource, rootScope) {
    return {
      coupons: function(){
        return resource(rootScope.restApiBaseUrl + '/api/coupons/:couponId/:action', null,
          {
            //list: { method: 'GET', params: {filter:'{"where":{"status":true},"include":["category","merchant","brand","location"]}'}, isArray: true},
            //list: { method: 'GET', params: {filter:{where:{status:true}}}, isArray: true},
            list: { method: 'GET', params: {}, isArray: true},
            get: { method: 'GET', params: {}},
            count:{ method: 'GET', params: {action:'count'}},
            update:{method:'PUT' ,params:{}}
          });
      },
    
      push: function(){
        return resource(rootScope.restApiBaseUrl + '/api/installations', null,
          {
            register:  { method: 'POST', params: {}}
          });
      }
    };
  }]);