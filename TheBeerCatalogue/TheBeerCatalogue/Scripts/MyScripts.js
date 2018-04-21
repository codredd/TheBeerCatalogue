$(document).ready(function () {
    $('#myGrid').DataTable({
        "ajax": {
            "url": "/Beer/GetBeer/",
            "dataSrc": ""
        },
        "columns": [
            { "data": "id" },
            { "data": "name" },
            { "data": "description" }]
    });
});