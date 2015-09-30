MarksSite.viewmodels.userListPage = function ($, ko) {

    function User(model) {
        var self = this;
        self.id = model.Id;
        self.domainName = model.DomainName;
        self.name = model.FullName;
        self.isManager = model.IsManager;
    }

    function bindUserList(model) {
        var users = model.map(function (item) {
            return new User(item);
        })
        var viewModel = {
            users: users
        };
        ko.applyBindings(viewModel);
    }

    return {
        bindUserList: bindUserList
    };
}(jQuery, ko);