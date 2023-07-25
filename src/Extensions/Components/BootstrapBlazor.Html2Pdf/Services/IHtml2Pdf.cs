﻿// Copyright (c) Argo Zhang (argo@163.com). All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
// Website: https://www.blazor.zone or https://argozhang.github.io/

namespace BootstrapBlazor.Components;

/// <summary>
/// Html export PDF service
/// </summary>
public interface IHtml2Pdf
{
    /// <summary>
    /// Export method
    /// </summary>
    /// <param name="html">snippet html</param>
    /// <param name="fileName">the file name of pdf</param>
    /// <returns></returns>
    Task<bool> ExportAsync(string html, string? fileName = null);

    /// <summary>
    /// 导出流
    /// </summary>
    /// <param name="html"></param>
    /// <returns></returns>
    Task<Stream> ExportStreamAsync(string html);
}