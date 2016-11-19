/*!
 * FileInput Danish Translations
 *
 * This file must be loaded after 'fileinput.js'. Patterns in braces '{}', or
 * any HTML markup tags in the messages must not be converted or translated.
 *
 * @see http://github.com/kartik-v/bootstrap-fileinput
 *
 * NOTE: this file must be saved in UTF-8 encoding.
 */
(function ($) {
    "use strict";

    $.fn.fileinputLocales['da'] = {
        fileSingle: 'fil',
        filePlural: 'filer',
        browseLabel: 'Gennemse &hellip;',
        removeLabel: 'Fjern',
        removeTitle: 'Ryd valgte filer',
        cancelLabel: 'Anull�r',
        cancelTitle: 'Afbryd',
        uploadLabel: 'Upload',
        uploadTitle: 'Upload valgte filer',
        msgSizeTooLarge: 'Filen "{name}" (<b>{size} KB</b>) overskrider den maksimale tilladte st�rrelse p� <b>{maxSize} KB</b>. Pr�v venligst igen efter at have gjort filen mindre',
        msgFilesTooLess: 'Du skal v�lge mindst <b>{n}</b> {files} til upload. Pr�v venligst igen',
        msgFilesTooMany: 'Antallet af filer <b>({n})</b> overskrider <b>{m}</b>. Reduc�r antallet af filer og pr�v igen',
        msgFileNotFound: 'Filen "{name}" kan ikke findes',
        msgFileSecured: 'Du har ikke tilladelse til at l�se filen "{name}".',
        msgFileNotReadable: 'Filen "{name}" kan ikke l�ses.',
        msgFilePreviewAborted: 'Preview annulleret "{name}".',
        msgFilePreviewError: 'Der opstod en fejl under l�sning af filen "{name}".',
        msgInvalidFileType: 'Ugyldig filtype "{name}". Kun "{types}" er underst�ttet.',
        msgInvalidFileExtension: 'Ugyldig fil-endelse "{name}". Kun "{extensions}" er underst�ttet.',
        msgValidationError: 'Der opstod en fejl',
        msgLoading: 'Loader fil {index} af {files} &hellip;',
        msgProgress: 'Loader fil {index} af {files} - {name} - {percent}% f�rdig.',
        msgSelected: '{n} {files} valgt',
        msgFoldersNotAllowed: 'Kun drag & drop. Skipped {n} dropped folder(s).',
        dropZoneTitle: 'Drag & drop filer her &hellip;'
    };
})(window.jQuery);