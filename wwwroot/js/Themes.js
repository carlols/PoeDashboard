const defaultTheme = "dark";
const themeKey = "poeDashboardTheme";

function ApplyTheme() {
    var theme = localStorage.getItem(themeKey);

    if (!theme) {
        theme = defaultTheme;
    }

    trans();
    $("html").attr("data-theme", theme);
}

function SaveThemeToLocalStorage(theme) {
    if (!theme) {
        theme = defaultTheme;
    }

    localStorage.setItem(themeKey, theme);
    ApplyTheme();
}

let trans = () => {
    document.documentElement.classList.add("transition");
    window.setTimeout(() => {
        document.documentElement.classList.remove("transition");
    },
        350);
}