var _getWaiver = function (id) {
        return new Promise(function (resolve, reject) {
            TFOAlert.blockPage();
            $.ajax({
                type: "GET",
                url: '/duplicatas/dashboardapi/getcontratowaiver',
                data: {
                    "ItemToCmd": id
                },
                success: function (data) {
                    TFOAlert.unblockPage();
                    resolve(data) // Resolve promise and when success
                },
                error: function (err) {
                    TFOAlert.unblockPage();
                    reject(err) // Reject the promise and go to catch()
                }
            });
        });
    }
	
	
	
	$('a.item-to-waiver').on('click', async function () {
            var itemToCmd = $(this).attr('data-item-id');
            try {
                var data = await _getWaiver(itemToCmd);
                if (data.status == true) {
                    $('#waiverForm').trigger("reset");

                    if (data.result) {
                        $('#waiverForm input[name=itemToCmd]').val(data.result.itemToCmd);
                        $('#waiverForm input[name=waiverInicioValidade]').val(_formatDate(data.result.waiverInicioValidade));
                        $('#waiverForm input[name=waiver]').val(data.result.waiver);
                        $("#waiverForm input[name=waiver]").trigger('change');
                    }
                    else {
                        $().val(itemToCmd);
                    }

                    $('#waiverModel').modal('show');
                }
                else
                    TFOAlert.showGenericError();
            } catch (e) {
                console.log(e);
                TFOAlert.showGenericError();
            }
        });

//pegando o form e serializando
$('form').serialize();
$( this ).serializeArray() );

//para evitar o erro 400
headers:
{
    "RequestVerificationToken": $('input:hidden[name="__RequestVerificationToken"]').val()
},
