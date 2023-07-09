﻿using System.IO;
using System.Xml.Linq;
using Penman.EpubSharp.Format;

namespace Penman.EpubSharp
{
    public interface IEpubWriter
    {
        void Write(EpubBook book, string epubBookPath);
        void Write(EpubBook book, Stream stream);
        void AddFile(string filename, byte[] content, EpubContentType type);
        void AddFile(string filename, string content, EpubContentType type);
        void AddAuthor(string authorName);
        void ClearAuthors();
        void RemoveAuthor(string author);
        void RemoveTitle();
        void SetTitle(string title);
        EpubChapter AddChapter(string title, string html, string fileId = null);
        void ClearChapters();
        void RemoveCover();
        void SetCover(byte[] data, ImageFormat imageFormat);
        byte[] Write();
        void Write(string epubBookPath);
        void Write(Stream stream);
        XElement FindNavTocOl();
    }
}