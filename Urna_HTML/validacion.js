// Contadores de votos por carrocería
let votosCarroceria1 = 0;
let votosCarroceria2 = 0;
let votosCarroceria3 = 0;

// Función para votar por una carrocería
function votar(carroceria) {
  if (carroceria === 1) {
    votosCarroceria1++;
  } else if (carroceria === 2) {
    votosCarroceria2++;
  } else if (carroceria === 3) {
    votosCarroceria3++;
  }

  // Actualizar visualización de votos y porcentajes
  mostrarResultados();
}

// Función para mostrar los resultados en tiempo real
function mostrarResultados() {
  const totalVotos = votosCarroceria1 + votosCarroceria2 + votosCarroceria3;

  const porcentajeCarroceria1 = (votosCarroceria1 / totalVotos) * 100 || 0;
  const porcentajeCarroceria2 = (votosCarroceria2 / totalVotos) * 100 || 0;
  const porcentajeCarroceria3 = (votosCarroceria3 / totalVotos) * 100 || 0;

  document.getElementById("carroceria1").textContent = `${votosCarroceria1} votos (${porcentajeCarroceria1.toFixed(2)}%)`;
  document.getElementById("carroceria2").textContent = `${votosCarroceria2} votos (${porcentajeCarroceria2.toFixed(2)}%)`;
  document.getElementById("carroceria3").textContent = `${votosCarroceria3} votos (${porcentajeCarroceria3.toFixed(2)}%)`;
}
