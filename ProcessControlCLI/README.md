# ProcessControlCLI

A command-line tool to simulate high CPU and memory usage, crash a process, and restart it while maintaining its previous state.

## Table of Contents

- [Setup](#setup)
- [Usage](#usage)
- [Examples](#examples)
- [Integration with Process Watcher](#integration-with-process-watcher)

## Setup

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (version 6.0 or later)

### Steps

1. **Clone the Repository**

    ```sh
    git clone https://github.com/your-repo/ProcessControlCLI.git
    cd ProcessControlCLI
    ```

2. **Open the Project in Visual Studio**

    - Open Visual Studio.
    - Select **File** -> **Open** -> **Project/Solution**.
    - Navigate to the `ProcessControlCLI` directory and open the solution file (`.sln`).

3. **Build the Project**

    - Build the solution to compile the project. You can do this by selecting **Build** -> **Build Solution** from the top menu or by pressing `Ctrl+Shift+B`.

## Usage

### Running the CLI

1. **Open Command Prompt** or **Terminal**.
2. **Navigate to the Project Directory**

    ```sh
    cd path\to\your\project\bin\Debug\net6.0
    ```

3. **Execute the CLI with Appropriate Arguments**

    ```sh
    ProcessControlCLI.exe [command] [options]
    ```

### Commands

- **cpu [percentage]**: Consume a specified percentage of CPU.
- **memory [megabytes]**: Consume a specified amount of memory in MB.
- **crash**: Crash the process.
- **restart**: Restart the process and restore its previous state.

### Options

- `percentage`: An integer value between 0 and 100 specifying the CPU usage percentage.
- `megabytes`: An integer value specifying the memory usage in MB.

## Examples

### Consume CPU

```sh
ProcessControlCLI.exe cpu 50
