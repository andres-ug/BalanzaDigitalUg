let chartRegistrosInstance = null;
window.renderChartRegistros = (labels, values) => {
    const ctx = document.getElementById('chartRegistros').getContext('2d');
    if (chartRegistrosInstance) {
        chartRegistrosInstance.data.labels = labels;
        chartRegistrosInstance.data.datasets[0].data = values;
        chartRegistrosInstance.update();
    } else {
        chartRegistrosInstance = new Chart(ctx, {
            type: 'bar',
            data: {
                labels: labels,
                datasets: [{
                    label: 'Peso total por tipo',
                    data: values,
                    backgroundColor: 'rgba(54, 162, 235, 0.5)',
                    borderColor: 'rgba(54, 162, 235, 1)',
                    borderWidth: 1
                }]
            },
            options: {
                responsive: true,
                scales: {
                    y: { beginAtZero: true }
                }
            }
        });
    }
};

