$('#btnsubmit').click(function (
) {
    let data = $('#contactForm').serialize();

    $.ajax({
        type: 'Post',
        url: 'https://localhost:44302/api/InsertProduct',
        data: data,
        success: function (responce) {
            alert("Product Successfully Added");
        },
        error: function () {
            alert("Data Not Added");
        }
    })
})