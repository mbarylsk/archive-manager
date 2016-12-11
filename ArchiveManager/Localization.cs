using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Globalization;
using System.Threading;

public enum LocalizedItem
{
    ButtonSearch,    
    ButtonReset,
    ButtonCancel,
    ButtonMove,
    ButtonExit,
    ButtonCreate,
    ButtonScan,
    TextPathToBeScanned,
    TextFileFilter,
    TextPathWithArchives,
    TextShowDuplicatesInArchives,
    TextSelectAll,
    TextDeselectAll,
    TextInvertSelection,
    TextExpandAll,
    TextCollapseAll,
    TextPathForQuarantine,
    TextFindDuplicates,
    TextManageArchives,
    TextPhase1Started,
    TextPhase2Started,
    TextPhase3Started,
    TextAppName,
    TextResetCompleted,
    TextAuthor,
    TextSearchForDuplicates,
    TextCreateArchive,
    TextRemoveDuplicates,
    TextScanArchives,
    TextOutputFile,
    TextThresholdPercentage,
    ErrorPathNotFound,
    ErrorFileFilterEmpty
}

class Localization
{
    private CultureInfo culture { get; set; }

    public Localization()
    {
        culture = Thread.CurrentThread.CurrentCulture;
    }

    public String GetValueForItem(LocalizedItem item, int maxLength)
    {        
        return ArchiveManager.Form_archmgr.StringShortenIfNeeded(GetValueForItem(item), maxLength);     
    }

    public String GetValueForItem(LocalizedItem item)
    {
        String value = String.Empty;
        switch (culture.Name)
        {
            case "pl-PL":
                switch (item)
                {
                    case LocalizedItem.TextAppName:
                        value = "Zarządca archiwum %s";
                        break;
                    case LocalizedItem.TextPathToBeScanned:
                        value = "Folder:";
                        break;
                    case LocalizedItem.TextPathWithArchives:
                        value = "Folder z archiwami:";
                        break;
                    case LocalizedItem.TextPathForQuarantine:
                        value = "Folder kwarantanny:";
                        break;
                    case LocalizedItem.TextResetCompleted:
                        value = "Wartości początkowe przywrócone.";
                        break;
                    case LocalizedItem.TextPhase1Started:
                        value = "Faza 1/3: Tworzenie listy plików rozpoczęte...";
                        break;
                    case LocalizedItem.TextPhase2Started:
                        value = "Faza 2/3: Tworzenie bazy plików rozpoczęte...";
                        break;
                    case LocalizedItem.TextPhase3Started:
                        value = "Faza 3/3: Szukanie duplikatów rozpoczęte...";
                        break;
                    case LocalizedItem.TextAuthor:
                        value = "Autor:";
                        break;
                    case LocalizedItem.TextSelectAll:
                        value = "Zaznacz wszystkie";
                        break;
                    case LocalizedItem.TextDeselectAll:
                        value = "Odznacz wszystkie";
                        break;
                    case LocalizedItem.TextInvertSelection:
                        value = "Odwróć zaznaczenie";
                        break;
                    case LocalizedItem.TextCollapseAll:
                        value = "Zwiń wszystkie";
                        break;
                    case LocalizedItem.TextExpandAll:
                        value = "Rozwiń wszystkie";
                        break;
                    case LocalizedItem.TextShowDuplicatesInArchives:
                        value = "Pokaż duplikaty w archiwach";
                        break;
                    case LocalizedItem.TextFileFilter:
                        value = "Filtr plików:";
                        break;
                    case LocalizedItem.TextFindDuplicates:
                        value = "Znajdź duplikaty";
                        break;
                    case LocalizedItem.TextManageArchives:
                        value = "Zarządzaj archiwami";
                        break;
                    case LocalizedItem.TextSearchForDuplicates:
                        value = "Szukaj duplikatów:";
                        break;
                    case LocalizedItem.TextRemoveDuplicates:
                        value = "Usuń duplikaty:";
                        break;
                    case LocalizedItem.TextCreateArchive:
                        value = "Stwórz archiwum:";
                        break;
                    case LocalizedItem.TextScanArchives:
                        value = "Przeszukaj archiwa:";
                        break;
                    case LocalizedItem.TextThresholdPercentage:
                        value = "Procent zgodności:";
                        break;
                    case LocalizedItem.TextOutputFile:
                        value = "Plik wynikowy:";
                        break;
                    case LocalizedItem.ButtonSearch:
                        value = "Szukaj";
                        break;
                    case LocalizedItem.ButtonMove:
                        value = "Przenieś";
                        break;
                    case LocalizedItem.ButtonCancel:
                        value = "Anuluj";
                        break;
                    case LocalizedItem.ButtonReset:
                        value = "Resetuj";
                        break;
                    case LocalizedItem.ButtonExit:
                        value = "Zakończ";
                        break;
                    case LocalizedItem.ButtonCreate:
                        value = "Stwórz";
                        break;
                    case LocalizedItem.ButtonScan:
                        value = "Skanuj";
                        break;
                    case LocalizedItem.ErrorPathNotFound:
                        value = "Błąd! Ścieżka nie istnieje.";
                        break;
                    case LocalizedItem.ErrorFileFilterEmpty:
                        value = "Błąd! Filtr plików jest pusty.";
                        break;
                    default:
                        value = String.Empty;
                        break;
                }
                break;
            default:
                switch (item)
                {
                    case LocalizedItem.TextAppName:
                        value = "Archive manager %s";
                        break;
                    case LocalizedItem.TextPathToBeScanned:
                        value = "Path to be scanned:";
                        break;
                    case LocalizedItem.TextPathWithArchives:
                        value = "Path with archives:";
                        break;
                    case LocalizedItem.TextPathForQuarantine:
                        value = "Path for quarantine:";
                        break;
                    case LocalizedItem.TextResetCompleted:
                        value = "Reset completed.";
                        break;    
                    case LocalizedItem.TextPhase1Started:
                        value = "Phase 1/3: Creation of file list started ...";
                        break;
                    case LocalizedItem.TextPhase2Started:
                        value = "Phase 2/3: Creation of file database started ...";
                        break;
                    case LocalizedItem.TextPhase3Started:
                        value = "Phase 3/3: Search of duplicates started ...";
                        break;
                    case LocalizedItem.TextAuthor:
                        value = "Author:";
                        break;
                    case LocalizedItem.TextSelectAll:
                        value = "Select all";
                        break;
                    case LocalizedItem.TextDeselectAll:
                        value = "Deselect all";
                        break;
                    case LocalizedItem.TextInvertSelection:
                        value = "Invert selection";
                        break;
                    case LocalizedItem.TextShowDuplicatesInArchives:
                        value = "Show duplicates in archives";
                        break;
                    case LocalizedItem.TextCollapseAll:
                        value = "Colapse all";
                        break;
                    case LocalizedItem.TextExpandAll:
                        value = "Expand all";
                        break;
                    case LocalizedItem.TextFileFilter:
                        value = "File filter:";
                        break;
                    case LocalizedItem.TextFindDuplicates:
                        value = "Find duplicates";
                        break;
                    case LocalizedItem.TextManageArchives:
                        value = "Manage archives";
                        break;
                    case LocalizedItem.TextSearchForDuplicates:
                        value = "Search for duplicates:";
                        break;
                    case LocalizedItem.TextRemoveDuplicates:
                        value = "Remove duplicates:";
                        break;
                    case LocalizedItem.TextCreateArchive:
                        value = "Create archive:";
                        break;
                    case LocalizedItem.TextScanArchives:
                        value = "Scan archives:";
                        break;
                    case LocalizedItem.TextThresholdPercentage:
                        value = "Threshold percentage:";
                        break;
                    case LocalizedItem.TextOutputFile:
                        value = "Output file:";
                        break;
                    case LocalizedItem.ButtonSearch:
                        value = "Search";
                        break;
                    case LocalizedItem.ButtonMove:
                        value = "Move";
                        break;
                    case LocalizedItem.ButtonCancel:
                        value = "Cancel";
                        break;
                    case LocalizedItem.ButtonReset:
                        value = "Reset";
                        break;
                    case LocalizedItem.ButtonExit:
                        value = "Exit";
                        break;
                    case LocalizedItem.ButtonCreate:
                        value = "Create";
                        break;
                    case LocalizedItem.ButtonScan:
                        value = "Scan";
                        break;
                    case LocalizedItem.ErrorPathNotFound:
                        value = "Error! Path does not exist";
                        break;
                    case LocalizedItem.ErrorFileFilterEmpty:
                        value = "Error! File filter is empty";
                        break;
                    default:
                        value = String.Empty;
                        break;
                }
                break;
        }
        return value;
    }
}