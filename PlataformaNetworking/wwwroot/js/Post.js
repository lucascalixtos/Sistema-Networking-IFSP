$('body').on('change', '#campoUploadImagem', function () {
    if (this.files && this.files[0]) {

        var FR = new FileReader();

        FR.addEventListener("load", function (e) {
            $("#imagemPerfilAlterar").attr('src', e.target.result);
            $("#imagemUpload").attr('src', e.target.result);
            $("#campoInputNovaImagem").val(e.target.result);
            $('#formAlterarImagem').submit(function (e) {
                e.preventDefault();
                $.ajax({
                    url: '/Usuarios/AlterarImagemPerfil',
                    type: 'post',
                    data: $('#formAlterarImagem').serialize(),
                    success: function () {
                        // Whatever you want to do after the form is successfully submitted
                    }
                });
            });
            $('#formAlterarImagem').submit();
        });

        FR.readAsDataURL(this.files[0]);
    }
});


