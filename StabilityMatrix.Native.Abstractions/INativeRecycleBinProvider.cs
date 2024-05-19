﻿namespace StabilityMatrix.Native.Abstractions;

public interface INativeRecycleBinProvider
{
    /// <summary>
    /// Moves a file to the recycle bin.
    /// </summary>
    /// <param name="path">The path of the file to be moved.</param>
    /// <param name="flags">The flags to be used for the operation.</param>
    void MoveFileToRecycleBin(string path, NativeFileOperationFlags flags = default);

    /// <summary>
    /// Moves the specified files to the recycle bin.
    /// </summary>
    /// <param name="paths">The paths of the files to be moved.</param>
    /// <param name="flags">The flags to be used for the operation.</param>
    void MoveFilesToRecycleBin(IEnumerable<string> paths, NativeFileOperationFlags flags = default);

    /// <summary>
    /// Moves the specified directory to the recycle bin.
    /// </summary>
    /// <param name="path">The path of the directory to be moved.</param>
    /// <param name="flags">The flags to be used for the operation.</param>
    void MoveDirectoryToRecycleBin(string path, NativeFileOperationFlags flags = default);

    /// <summary>
    /// Moves the specified directories to the recycle bin.
    /// </summary>
    /// <param name="paths">The paths of the directories to be moved.</param>
    /// <param name="flags">The flags to be used for the operation.</param>
    void MoveDirectoriesToRecycleBin(IEnumerable<string> paths, NativeFileOperationFlags flags = default);
}
