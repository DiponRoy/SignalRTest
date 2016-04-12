/*TODO: can create new object of it*/
define('model.devtest',
    ['ko'],
    function(ko) {

        var model = function() {
            var self = this;
            self.id = ko.observable();
            self.campaingnName = ko.observable();
            self.date = ko.observable();
            self.clicks = ko.observable();
            self.conversions = ko.observable();
            self.impressions = ko.observable();
            self.affiliateName = ko.observable();
        };
        return model;
    });


