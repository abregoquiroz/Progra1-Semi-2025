var formActivo = "";
document.addEventListener("DOMContentLoaded", e => {
    mnxAcademica.addEventListener("click", event => {
        event.preventDefault();
        abrirVentana(event.target.dataset.form);
    });
});
function abrirVentana(form) {
    let $ventana = $(`#${form}`); //#alumno, #docente, #materia
    if ($ventana.find('form').length > 0) {
        $ventana.show();
    } else {
        let url = `/views/${form}.html`;
        fetch(url).then(resp => resp.text()).then(vista => {
            $(`#${form}`).html(vista).draggable();
            cerrarVentana();
        });
    }
}
function cerrarVentana() {
    $('.btn-close').click(e => {
        $(`#${e.target.dataset.form}`).hide();
    });
}

async function obtenerAlumnos(buscar = '') {
    const respuesta = await fetch(`/api/Alumnos/buscar?buscar=${buscar}`, {
        method: 'GET',
        headers: {
            "Content-Type": "application/json"
        }
    }), alumnos = await respuesta.json();
    return alumnos;
}

async function obtenerPeriodos(buscar = '') {
    const respuesta = await fetch(`/api/Periodos/buscar?buscar=${buscar}`, {
        method: 'GET',
        headers: {
            "Content-Type": "application/json"
        }
    }), periodos = await respuesta.json();
    return periodos;
}