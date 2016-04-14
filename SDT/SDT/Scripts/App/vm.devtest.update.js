define("vm.devtest.update",
["ko", "notify", "model.devtest", "dataservice.devtest"],
function (ko, notify, devtest, service) {

    var model = new devtest(),
        load = function(id) {
            service.get({
                success: function (data) {
                    ko.mapping.fromJS(data, {}, model);
                },
                error: function () {
                    notify.error("Error to load dev test.");
                }
            }, id);
        },
        update = function() {
            service.update({
                success: function (data) {
                    notify.success('Dev test updated.');
                },
                error: function () {
                    notify.error("Error to update dev test.");
                }
            }, ko.mapping.toJS(model));
        },
        reset = function() {
            load(model.id());
        };

    return {        
        model: model,
        load: load,
        update: update,
        reset: reset
    };
});