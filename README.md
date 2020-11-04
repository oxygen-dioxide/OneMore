﻿# ![logo](Screenshots/Logo.jpg "logo") OneMore - a OneNote Add-in

A OneNote add-in with powerful yet simple and effective features.

See the [**project wiki**](../../wiki) for full details. Meanwhile, here's some pleasant reading material...

* Access all features from the [OneMore group menus](../../wiki) added to the Home ribbon
* Access some "key" features using keyboard shortcuts (see what I did there?)
* Create/edit/apply [custom styles](../../wiki/Custom-Styles) with advanced options
* Manage menu of [Favorites](../../wiki/Favorites) for one-click link to your most referenced pages
* Add [formulas](../../wiki/Formula-Commands) to table cell using Excel-like expressions
* [Customize the context menu](../../wiki/Settings) to add OneMore commands or a a custom search engine

*Want more from OneMore? OneMore has more...* [Click here to see a list of all features](#features)

![screenshot](../../wiki/images/Screenshot.png)

<a name="features"></a>
## Features

[Clean commands](../../wiki/Clean-Commands)

* Remove author/citation information from paragraphs
* Remove pasted screen clipping and URL citation lines from page
* Remove empty headers and "extra" empty lines between paragraphs
* Remove spacing between paragraphs and headings
* Show/Hide the page date and time stamps under the title on page or all pages in section
* Trim trailing whitespace from selected text

[Custom Styles](../../wiki/Custom-styles)

* Manage custom style themes. Save, load separate themes
* Apply custom styles to selected text
* Apply an entire theme to a page
* Change page background to any custom color with dark-mode awareness

[Edit Commands](../../wiki/Edit-Commands)
* Disable spell-check on the current page (F4)
* Paste Rich Text (preserve colors when pasting code from Visual Studio)<sup>1</sup> (Ctrl+Alt+V)
* Search and replace text on the current page (Ctrl+H)
* Change selected text to UPPERCASE or lowercase
* Increase/Decrease the font size of all content on the current page

[Footnote Commands](../../wiki/Footnote-Commands)
* Insert a new footnote (endnote) at the current location
* Remove a footnote from either the label or from the footer description

[Formula commands](../../wiki/Formula-Commands)

* Calculate Excel-like formulas in tables (F5)
* Delete formula from selected table cells
* Highlight all cells on the page with custom formulas
* Recalculate all formulas in selected tables on the page (Shift + F5)

[Image commands](../../wiki/Image-Commands)

* Add caption to a selected images
* Precisely crop a selected image
* Resize a selected image or all images on the page

[Numbering commands](../../wiki/Numbering-Commands)

* Number page headings with numeric or alpha-numeric outline prefixes
* Number all sections in the current notebook
* Number all pages in the current section with numeric or alpha-numeric prefixes
* Remove numbering from sections
* Remove numbering from pages

[Snippets commands](../../wiki/Snippets-Commands)

* Insert single or double horizontal line
* Insert Table of Contents of headers, pages, or sections
* Insert small or large monthly calendar for a specific month
* Insert Info/Warn boxes similar to Confluence Info and Warn macros
* Insert Code box similar to Confluence Code macro
* Insert collapsable sections to hide secondary or sensitive information
* Insert status labels similar to the Confluence status macro

[Extra commands](../../wiki/Extra-Commands)

* Add special icon to the page title, also appears in page hierarchy
* Collapse the page hierarchy to see only top-level pages
* Convert select text to a table
* Insert pronunciation of words from over a dozen languages
* Merge pages, preserving formatting and position of outlines
* Replace hyperlinked URLs with their Web page titles
* Search for keywords and copy/move selected pages (Alt + F)
* Sort pages, sections, or notebooks
* Toggle strikethrough text next to all completed/incompleted tags

[Tools](../../wiki/Tools)

* Import MSWord and PowerPoint into the current page or a new page
* Export the current page or selected pages as HTML, PDF, MSWord, or as raw OneNote XML
* Invoke an external custom plugin to process a page
* View and edit the internal OneNote XML of the current page
* Check for updates and install upgrades on-demand

### Why?

I wanted something more than what OneNote provided. I was overwhelmed by _OneNote Gem_,
aghast at its bloated useless overloads of what was already otherwise available or features that
I would never use in a million years - and, oh yeah, that price! I admit I was intrigued by the
_Onetastic Macro_ approach but thought it limited and obtuse, decipherable only by programmers.
And both of these charge money for something that should be open source and neither provided exactly
what I wanted. So I did what any self respecting software engineer would do... I built my own.
Deal with it.

**Please Support**  
I do this as a hobby. I will never charge you to use OneMore. So it is with great humility and
appreciation that I humbly request that you consider a small donation to support the development
of OneMore. In exchange, I pledge to continue listening with an open mind and to respond to your
questions and tips in a timely manner.

_Click here, click now, click often! >>_  
>  [![Donate](Screenshots/Donate.png)](https://paypal.me/stevenmcohn?locale.x=en_US)


### Minimum Prerequisites

* Developed for Windows 10
* Microsoft Visual Studio 2019, C# 7
* Microsoft Visual Studio 2019 Installer Projects extension
* .NET Framework 4.8
* Microsoft OneNote 2016 32-bit or 64-bit

Tested recently with Windows 10 2004 (19041.450), VS2019, and OneNote 2019/O365


### How to Install

1. Close OneNote if it is currently running
2. Download the [latest installer from here](https://github.com/stevencohn/OneMore/releases/latest)
3. Right-click the downloaded installer msi and choose Properties, then tick the Unblock box and click OK
4. Run the installer
5. Run OneNote and enjoy

---

### Developing OneMore

See the [Developer Notes](../../wiki/Developer-Notes) page in the Wiki where I keep a list of 
technical references and information regarding developing and debugging this OneNote add-in.
