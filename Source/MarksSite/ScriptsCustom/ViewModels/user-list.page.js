MarksSite.viewmodels.userListPage = function ($, ko) {

    function User(model) {
        var self = this;
        self.id = model.Id;
        self.domainName = model.DomainName;
        self.name = model.FullName;
        self.isManager = model.IsManager;
        self.selected = ko.observable(false);
        self.selectedId = ko.observable();
    }

    function UserList(model) {
        var self = this;

        var users = model.map(function (item) {
            return new User(item);
        });
        self.users = users;

        self.selectedUsers = ko.computed(function () {
            var selectedItems = ko.utils.arrayFilter(self.users, function (item) {
                return item.selected();
            });
            return selectedItems.map(function (item) {
                return item.id;
            });
        });

        self.markingUrl = ko.computed(function () {
            if (!self.selectedUsers().length) {
                return "#";
            }
            return "/mark/AddNewMark?forWhom=" + self.selectedUsers()[0];
        });

        self.sendRequest = function () {
            var list = self.selectedUsers();
            var selectedUserIds = JSON.parse(ko.toJSON(list));
            $.ajax({
                url: "/User/SendUsers",
                type: "POST",
                data: JSON.stringify(data),
                success: function () {
                    window.location.href = "/";
                },
                contentType: "application/json"
            });
        }
    }
    function bindUserList(model) {

        var viewModel = new UserList(model);
        ko.applyBindings(viewModel);
    }

    return {
        bindUserList: bindUserList
    };
}(jQuery, ko);