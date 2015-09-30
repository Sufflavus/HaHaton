MarksSite.viewmodels.defaultPage = function ($, ko) {
    
    function User(model) {
        var self = this;
        self.domainName = model.DomainName;
        self.name = model.FullName;
        self.isManager = model.IsManager;
        self.requests = initRequests();

        function initRequests() {
            if (!model.Requests) {
                return [];
            }

            return model.Requests.map(function(item) {
                return {
                    date: item.Date,
                    author: item.Author,
                    employee: item.Employee
                };
            });
        }
    }

    function bindUser(model) {
        var user = new User(model);
        ko.applyBindings(user);
    }

    return {
        bindUser: bindUser
    };
}(jQuery, ko);