# Stability Matrix

[![Build](https://github.com/LykosAI/StabilityMatrix/actions/workflows/build.yml/badge.svg)](https://github.com/LykosAI/StabilityMatrix/actions/workflows/build.yml)
[![Discord Server](https://img.shields.io/discord/1115555685476868168?logo=discord&logoColor=white&label=Discord%20Server)](https://discord.com/invite/TUrgfECxHz)

[![Neueste stabile Version](https://img.shields.io/github/v/release/LykosAI/StabilityMatrix?label=Latest%20Stable&link=https%3A%2F%2Fgithub.com%2FLykosAI%2FStabilityMatrix%2Freleases%2Flatest)][release]
[![Neueste Vorschau](https://img.shields.io/badge/dynamic/json?url=https%3A%2F%2Fcdn.lykos.ai%2Fupdate-v3.json&query=%24.updates.preview%5B%22win-x64%22%5D.version&prefix=v&label=Latest%20Preview&color=b57400&cacheSeconds=60&link=https%3A%2F%2Flykos.ai%2Fdownloads)](https://lykos.ai/downloads)
[![Neueste Entwicklerversion](https://img.shields.io/badge/dynamic/json?url=https%3A%2F%2Fcdn.lykos.ai%2Fupdate-v3.json&query=%24.updates.development%5B%22win-x64%22%5D.version&prefix=v&label=Latest%20Dev&color=880c21&cacheSeconds=60&link=https%3A%2F%2Flykos.ai%2Fdownloads)](https://lykos.ai/downloads)

[release]: https://github.com/LykosAI/StabilityMatrix/releases/latest
[download-win-x64]: https://github.com/LykosAI/StabilityMatrix/releases/latest/download/StabilityMatrix-win-x64.zip
[download-linux-appimage-x64]: https://github.com/LykosAI/StabilityMatrix/releases/latest/download/StabilityMatrix-linux-x64.zip
[download-linux-aur-x64]: https://aur.archlinux.org/packages/stabilitymatrix
[download-macos-arm64]: https://github.com/LykosAI/StabilityMatrix/releases/latest/download/StabilityMatrix-macos-arm64.dmg

[auto1111]: https://github.com/AUTOMATIC1111/stable-diffusion-webui
[auto1111-directml]: https://github.com/lshqqytiger/stable-diffusion-webui-directml
[webui-ux]: https://github.com/anapnoe/stable-diffusion-webui-ux
[comfy]: https://github.com/comfyanonymous/ComfyUI
[sdnext]: https://github.com/vladmandic/automatic
[voltaml]: https://github.com/VoltaML/voltaML-fast-stable-diffusion
[invokeai]: https://github.com/invoke-ai/InvokeAI
[fooocus]: https://github.com/lllyasviel/Fooocus
[fooocus-mre]: https://github.com/MoonRide303/Fooocus-MRE
[ruined-fooocus]: https://github.com/runew0lf/RuinedFooocus
[fooocus-controlnet]: https://github.com/fenneishi/Fooocus-ControlNet-SDXL
[kohya-ss]: https://github.com/bmaltais/kohya_ss
[onetrainer]: https://github.com/Nerogar/OneTrainer
[forge]: https://github.com/lllyasviel/stable-diffusion-webui-forge
[stable-swarm]: https://github.com/Stability-AI/StableSwarmUI
[sdfx]: https://github.com/sdfxai/sdfx
[fooocus-mashb1t]: https://github.com/mashb1t/Fooocus
[reforge]: https://github.com/Panchovix/stable-diffusion-webui-reForge

[civitai]: https://civitai.com/
[huggingface]: https://huggingface.co/

![Header-Bild für Stability Matrix, Multi-Plattform-Paketmanager und Inferenz-Benutzeroberfläche für Stable Diffusion](https://cdn.lykos.ai/static/sm-banner-rounded.webp)

[![Windows](https://img.shields.io/badge/Windows%2010,%2011-%230079d5.svg?style=for-the-badge&logo=Windows%2011&logoColor=white)][download-win-x64]
[![Linux (AppImage)](https://img.shields.io/badge/Linux%20(AppImage)-FCC624?style=for-the-badge&logo=linux&logoColor=black)][download-linux-appimage-x64]
[![Arch Linux (AUR)](https://img.shields.io/badge/Arch%20Linux%20(AUR)-1793D1?style=for-the-badge&logo=archlinux&logoColor=white)][download-linux-aur-x64]
[![macOS](https://img.shields.io/badge/mac%20os%20(apple%20silicon)-000000?style=for-the-badge&logo=macos&logoColor=F0F0F0)][download-macos-arm64]

Multi-Plattform-Paketmanager und Inferenz-Benutzeroberfläche für Stable Diffusion

### 🖱️ Ein-Klick-Installation und -Update für Stable Diffusion Web UI Pakete
- Unterstützt:
  - [Stable Diffusion WebUI reForge][reforge], [Stable Diffusion WebUI Forge][forge], [Automatic 1111][auto1111], [Automatic 1111 DirectML][auto1111-directml], [SD Web UI-UX][webui-ux], [SD.Next][sdnext]
  - [Fooocus][fooocus], [Fooocus MRE][fooocus-mre], [Fooocus ControlNet SDXL][fooocus-controlnet], [Ruined Fooocus][ruined-fooocus], [Fooocus - mashb1t's 1-Up Edition][fooocus-mashb1t]
  - [ComfyUI][comfy]
  - [StableSwarmUI][stable-swarm]
  - [VoltaML][voltaml]
  - [InvokeAI][invokeai]
  - [SDFX][sdfx]
  - [Kohya's GUI][kohya-ss]
  - [OneTrainer][onetrainer]
- Plugins/Erweiterungen für unterstützte Pakete verwalten ([Automatic1111][auto1111], [Comfy UI][comfy], [SD Web UI-UX][webui-ux], und [SD.Next][sdnext])
- Einfach Python-Abhängigkeiten für jedes Paket installieren oder aktualisieren
- Eingebettete Git- und Python-Abhängigkeiten, keine globale Installation erforderlich
- Vollständig portabel - Verschieben des Stability Matrix-Datenverzeichnisses auf ein neues Laufwerk oder einen neuen Computer jederzeit möglich

### ✨ Inferenz - Eine neu gestaltete Oberfläche für Stable Diffusion, in Stability Matrix integriert
- Leistungsstarke Autovervollständigung und Syntaxhervorhebung mithilfe einer formalen Sprachgrammatik
- Arbeitsbereiche öffnen sich in Registerkarten, die von `.smproj`-Projektdateien gespeichert und geladen werden

![](https://cdn.lykos.ai/static/sm-banner-inference-rounded.webp)

- Anpassbare, andockbare und schwebende Fenster
- Generierte Bilder enthalten Inferenzprojekt-, ComfyUI-Knoten- und A1111-kompatible Metadaten
- Drag & Drop-Galeriebilder oder Dateien zum Laden von Zuständen

<p align="center">
  <img style="width: 80%; height: 80%" src="https://github.com/LykosAI/StabilityMatrix/assets/13956642/4341cc34-a584-4e9c-bb3b-276009bdae80" alt=""/>
</p>

### 🚀 Launcher mit Syntax-hervorgehobenen Terminalemulator, geroutete GUI-Eingabeaufforderungen
- Startargumente-Editor mit vordefinierten oder benutzerdefinierten Optionen für jede Paketinstallation
- Konfigurierbare Umgebungsvariablen

<p align="center">
  <img style="width: 80%; height: 80%" src="https://github.com/LykosAI/StabilityMatrix/assets/13956642/75456866-9d95-47c6-8c0a-fdc19443ee02" alt=""/>
</p>

### 🗃️ Checkpoint-Manager, konfiguriert zur gemeinsamen Nutzung durch alle Paketinstallationen
- Option zum Auffinden von CivitAI-Metadaten und Vorschaubildern für neue lokale Importe

### ☁️ Modell-Browser zum Importieren von [CivitAI][civitai] und [HuggingFace][huggingface]
- Automatischer Import in den zugehörigen Modellordner, abhängig vom Modelltyp
- Lädt relevante Metadateien und Vorschaubilder herunter
- Downloads können pausiert und fortgesetzt werden, auch nach dem Schließen der App

<p align="center">
  <img style="width: 80%; height: 80%" src="https://github.com/LykosAI/StabilityMatrix/assets/13956642/30b9f610-6033-4307-8d92-7d72

b93cd73e" alt=""/>
</p>

### Gemeinsames Modellverzeichnis für alle deine Pakete
- Lokale Modelle durch einfaches Drag & Drop importieren
- Option, automatisch CivitAI-Metadaten und Vorschaubilder für neue lokale Importe zu finden

<p align="center">
  <img style="width: 80%; height: 80%" src="https://github.com/LykosAI/StabilityMatrix/assets/13956642/d42d1c53-67a4-45a0-b009-21400d44e17e" alt=""/>
</p>

- Verbundene Metadaten für bestehende Modelle finden
<p align="center">
  <img style="width: 80%; height: 80%" src="https://cdn.lykos.ai/static/sc-checkpoints-find-connected.gif" alt=""/>
</p>

## Lokalisierung
Stability Matrix ist dank unserer Community-Beitragenden jetzt in den folgenden Sprachen verfügbar:
- 🇺🇸 Englisch
- 🇯🇵 日本語 
  - kgmkm_mkgm
- 🇨🇳 中文（简体，繁体）
  - jimlovewine
- 🇮🇹 Italienisch
  - Marco Capelli
- 🇫🇷 Französisch
  - eephyne
  - Greg
- 🇪🇸 Spanisch
  - Carlos Baena 
  - Lautaroturina
- 🇷🇺 Russisch
  - aolko
  - den1251
- 🇹🇷 Türkisch
  - Progesor
- 🇩🇪 Deutsch
  - Mario da Graca
- 🇵🇹 Portugiesisch
  - nextosai
- 🇧🇷 Portugiesisch (Brasilien)
  - jbostroski
  - thiagojramos
- 🇰🇷 Koreanisch
  - maakcode

Wenn du eine Übersetzung beitragen möchtest, erstelle bitte ein Issue oder kontaktiere uns auf Discord. Gib eine E-Mail-Adresse an, an die wir eine Einladung zu unserem [POEditor](https://poeditor.com/) Projekt senden können.

## Haftungsausschlüsse
Alle Marken, Logos und Markennamen sind Eigentum ihrer jeweiligen Inhaber. Alle in diesem Dokument und lizenzierten Anwendungen verwendeten Firmen-, Produkt- und Dienstleistungsnamen dienen nur zur Identifikation. Die Verwendung dieser Namen, Marken und Logos impliziert keine Befürwortung.

## Lizenz

Dieses Repository enthält den neuesten Quellcode-Release von Stability Matrix und ist unter der [GNU Affero General Public License](https://www.gnu.org/licenses/agpl-3.0.en.html) lizenziert. Binär- und ausführbare Veröffentlichungen sind unter der [Endbenutzer-Lizenzvereinbarung](https://lykos.ai/license) lizenziert.
