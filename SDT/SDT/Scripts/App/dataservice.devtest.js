define('dataservice.devtest',
    ['amplify'],
    function(amplify) {

        var init = function() {

            amplify.request.define('devtests.all', 'ajax', {
                url: '/api/devtests',
                dataType: 'json',
                type: 'GET'
            }),
            amplify.request.define('devtests.get', 'ajax', {
                url: '/api/devtests/{id}',
                dataType: 'json',
                type: 'GET'
            });

            amplify.request.define('devtests.create', 'ajax', {
                url: '/api/devtests',
                dataType: 'json',
                type: 'POST',
            });

            amplify.request.define('devtests.update', 'ajax', {
                url: '/api/devtests/{id}',
                dataType: 'json',
                type: 'PUT',
            });

            amplify.request.define('devtests.remove', 'ajax', {
                url: '/api/devtests/{id}',
                dataType: 'json',
                type: 'DELETE',
            });
        },
            all = function(callbacks) {
                return amplify.request({
                    resourceId: 'devtests.all',
                    success: callbacks.success,
                    error: callbacks.error
                });
            },
            get = function(callbacks, id) {
                return amplify.request({
                    resourceId: 'devtests.get',
                    data: { id: id },
                    success: callbacks.success,
                    error: callbacks.error
                });
            },
            create = function(callbacks, data) {
                return amplify.request({
                    resourceId: 'devtests.create',
                    data: data,
                    success: callbacks.success,
                    error: callbacks.error
                });
            },
            update = function(callbacks, data) {
                return amplify.request({
                    resourceId: 'devtests.update',
                    data: data,
                    success: callbacks.success,
                    error: callbacks.error
                });
            },
            remove = function(callbacks, data) {
                return amplify.request({
                    resourceId: 'devtests.remove',
                    data: data,
                    success: callbacks.success,
                    error: callbacks.error
                });
            };

        init();

        return {
            all: all,
            get: get,
            create: create,
            update: update,
            remove: remove
        };
    });