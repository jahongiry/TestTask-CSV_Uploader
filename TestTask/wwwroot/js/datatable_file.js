$(document).ready(function () {
    GetCustomer();
});

function GetCustomer() {
    $.ajax({
        url: '/Employees/GetData',
        type: 'Get',
        dataType: 'json',
        success: OnSuccess
    })
}

function OnSuccess(response) {
    $('#dataTableData').DataTable({
        bProcessing: true,
        bLengthChange: true,
        lengthMenu: [[5, 10, 25, -1], [5, 10, 25, "All"]],
        bfileter: true,
        bSort: true,
        bPaginate: true,
        data: response,
        order: [[2, 'asc']],
        columns: [
            {
                data: 'PayrollNumber',
                render: function (data, type, row, meta) {
                    return row.payrollNumber
                }
            },
            {
                data: 'Forename',
                render: function (data, type, row, meta) {
                    return row.forename
                }
            },
            {
                data: 'Surname',
                render: function (data, type, row, meta) {
                    return row.surname
                }
            },
            {
                data: 'DateofBirth',
                render: function (data, type, row, meta) {
                    return row.dateofBirth
                }
            },
            {
                data: 'Telephone',
                render: function (data, type, row, meta) {
                    return row.telephone
                }
            },
            {
                data: 'Mobile',
                render: function (data, type, row, meta) {
                    return row.mobile
                }
            },
            {
                data: 'Address',
                render: function (data, type, row, meta) {
                    return row.address
                }
            },
            {
                data: 'Address2',
                render: function (data, type, row, meta) {
                    return row.address2
                }
            },
            {
                data: 'Postcode',
                render: function (data, type, row, meta) {
                    return row.postcode
                }
            },
            {
                data: 'EMailHome',
                render: function (data, type, row, meta) {
                    return row.eMailHome
                }
            },
            {
                data: 'StartDate',
                render: function (data, type, row, meta) {
                    return row.startDate
                }
            },
        ]
    });
}