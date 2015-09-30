MarksSite.viewmodels.markNewPage = function ($, ko) {

    function Mark(model) {
        var self = this;        
        self.toId = model.ToId;
        self.from = model.From;
        self.to = model.To;        

        self.markDetails = {
            Productivity: {
                Value: ko.observable(),
                Comment: ko.observable(),
            },
            Quality: {
                Value: ko.observable(),
                Comment: ko.observable(),
            },
            Discipline: {
                Value: ko.observable(),
                Comment: ko.observable(),
            },
            Cooperation: {
                Value: ko.observable(),
                Comment: ko.observable(),
            },
            Skills: {
                Value: ko.observable(),
                Comment: ko.observable(),
            },
            Initiative: {
                Value: ko.observable(),
                Comment: ko.observable(),
            },
            Growth: {
                Value: ko.observable(),
                Comment: ko.observable(),
            }
        };

        self.markType = [
            {
                id: 1,
                value: "O"
            },
            {
                id: 2,
                value: "EE"
            },
            {
                id: 3,
                value: "S"
            },
            {
                id: 4,
                value: "NI"
            },
            {
                id: 5,
                value: "U"
            }
        ];

        self.saveMark = function () {
            var dataForPost = JSON.parse(ko.toJSON(self));
            dataForPost.ToId = self.toId;
            dataForPost.MarkDetails = dataForPost.markDetails;
            dataForPost.markDetails = null;
            dataForPost.markType = null;
            //console.log(dataForPost);
            $.ajax({
                url: "/Mark/SaveMark",
                type: "POST",
                data: JSON.stringify(dataForPost),
                success: function () {
                    window.location.href = "/";
                },
                contentType: "application/json"
            });
        };

        self.isValid = ko.computed(function() {
            return !!self.markDetails.Productivity.Value() &&
                !!self.markDetails.Quality.Value() &&
                !!self.markDetails.Discipline.Value() &&
                !!self.markDetails.Cooperation.Value() &&
                !!self.markDetails.Skills.Value() &&
                !!self.markDetails.Initiative.Value() &&
                !!self.markDetails.Growth.Value();
        });
    }

    function bindMarkList(model) {        
        ko.applyBindings(new Mark(model));
    }

    return {
        bindMarkList: bindMarkList
    };
}(jQuery, ko);