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

function readURL(input) {
    if (input.files && input.files[0]) {

        var reader = new FileReader();

        reader.onload = function (e) {
            $('.image-upload-wrap').hide();

            $('.file-upload-image').attr('src', e.target.result);
            $('.file-upload-content').show();
            $("#ImagemPost").val(e.target.result);

            $('.image-title').html(input.files[0].name);
        };

        reader.readAsDataURL(input.files[0]);

    } else {
        removeUpload();
    }
}

function removeUpload() {
    $('.file-upload-input').replaceWith($('.file-upload-input').clone());
    $('.file-upload-content').hide();
    $('.image-upload-wrap').show();
}
$('.image-upload-wrap').bind('dragover', function () {
    $('.image-upload-wrap').addClass('image-dropping');
});
$('.image-upload-wrap').bind('dragleave', function () {
    $('.image-upload-wrap').removeClass('image-dropping');
});

$('body').on('change', '#UploadImagem', function () {
    if (this.files && this.files[0]) {

        var FR = new FileReader();

        FR.addEventListener("load", function (f) {
            $("#imagemUpload").attr('src', f.target.result);
            $("#campoInputNovaImagem").val(f.target.result);
            $('#formUploadImagem').submit(function (f) {
                f.preventDefault();
                $.ajax({
                    url: '/Usuarios/AlterarImagemPerfil',
                    type: 'post',
                    data: $('#formUploadImagem').serialize(),
                    success: function () {
                        // Whatever you want to do after the form is successfully submitted
                    }
                });
            });
            $('#formUploadImagem').submit();

        });

        FR.readAsDataURL(this.files[0]);
    }
});

$('body').on('submit', '#formNewPostagem', function (evt) {
    evt.preventDefault();
    $.ajax({
        url: '/Publicacoes/NovaPublicacao',
        type: 'post',
        data: $('#formNewPostagem').serialize(),
        success: function () {
            document.location.reload();
        }
    });
});


$('body').on('submit', '#formNewHabilidade', function (evt) {
    evt.preventDefault();
    $.ajax({
        url: '/Usuarios/NovaHabilidade',
        type: 'post',
        data: $('#formNewHabilidade').serialize(),
        success: function () {
            document.location.reload();
        }
    });
});


$('body').on('submit', '#formNewVaga', function (evt) {
    evt.preventDefault();
    //throw new error("Passou aqui");
    $.ajax({
        url: '/Vaga/NovaVaga',
        type: 'post',
        data: $('#formNewVaga').serialize(),
        success: function () {
            document.location.reload();
        }
    });
});

$('#btnCandidatar').on('click',function (evt) {
    evt.preventDefault();
    //throw new error("Passou aqui");
    $.ajax({
        type: "POST",
        url: "/Vaga/Candidatar",
        async: true,
        success: function () {
            document.location.reload();
        }
    });
});

$('body').on('click', '#triggerUploadClick', function (){
    document.getElementById("campoUploadImagem").click();
});

$('body').on('click', '#triggerUpload', function () {
    document.getElementById("UploadImagem").click();
});

$("#adicionarHabilidade").click(function () {
    $("#formNewHabilidade").show();
});


