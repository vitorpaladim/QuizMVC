function selectOption(option) {
    console.log("Resposta selecionada: " + option);
    // Aqui você pode registrar a resposta e atualizar o estado do quiz.
}

function navigate(direction) {
    if (direction === 'next') {
        // Lógica para avançar para a próxima questão
        console.log("Avançando para a próxima questão...");
    } else if (direction === 'previous') {
        // Lógica para voltar à pergunta anterior
        console.log("Voltando para a questão anterior...");
    }
}
