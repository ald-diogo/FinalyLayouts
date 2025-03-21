// Função que retorna se o sistema está no modo escuro
window.getSystemTheme = () => {
    return window.matchMedia("(prefers-color-scheme: dark)").matches;
};

// Função que observa mudanças no tema do sistema e comunica o Blazor
window.watchSystemTheme = (dotnetHelper) => {
    const mediaQuery = window.matchMedia("(prefers-color-scheme: dark)");

    // Adiciona um ouvinte para detectar mudanças no tema
    const listener = (event) => {
        dotnetHelper.invokeMethodAsync("SetDarkMode", event.matches);
    };

    mediaQuery.addEventListener("change", listener);
};