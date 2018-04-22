$(document).ready(function () {
    $('#myGrid').DataTable({
        "ajax": {
            "url": "/Beer/GetBeer/",
            "dataSrc": ""
        },
        "columns": [
            { "data": "name" },
            { "data": "id" },
            { "data": "description" }]
    });
});