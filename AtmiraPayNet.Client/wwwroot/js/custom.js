window.customFunctions = {
    selectFolder: function (dotNetHelper) {
        const input = document.createElement('input');
        input.type = 'file';
        input.style.display = 'none';
        input.setAttribute('webkitdirectory', 'true');
        input.setAttribute('directory', 'true');

        input.addEventListener('change', function (event) {
            const folderPath = event.target.files[0].path;
            dotNetHelper.invokeMethodAsync('FolderSelected', folderPath);
        });

        document.body.appendChild(input);
        input.click();
        document.body.removeChild(input);
    }
};
