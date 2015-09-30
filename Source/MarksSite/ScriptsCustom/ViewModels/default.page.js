MarksSite.viewmodels.defaultPage = function ($, ko) {
    
    function User(model) {
        var self = this;
        self.domainName = model.DomainName;
        self.name = model.Name;
    }

    function bindUser(model) {
        var user = new User(model);
        ko.applyBindings(user);
    }

    return {
        bindUser: bindUser
    };
}(jQuery, ko);