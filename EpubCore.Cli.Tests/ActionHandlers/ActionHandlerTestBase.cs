﻿using AutoFixture;
using EpubCore.Cli.Managers;
using Moq;

namespace EpubCore.Cli.Tests.ActionHandlers;

public class ActionHandlerTestBase
{
    protected const string TestEPub = "TestData/test1.epub";
    protected const string TestEPubResult = "test1-result.epub";
    protected Fixture Fixture = new Fixture();
    protected Mock<IConsoleWriter> ConsoleWriter;
    protected Mock<EpubResourceManager> ResourceRetriever;
    protected string PathToTestEpub { get; set; }

    protected ActionHandlerTestBase()
    {
        ConsoleWriter = new Mock<IConsoleWriter>();
        ResourceRetriever = new Mock<EpubResourceManager>();
    }

    public string GivenAnEpub(string epubName)
    {
        return GivenAFile(epubName);
    }

    public string GivenAFile(string fileName)
    {
        return Path.Join(AppDomain.CurrentDomain.BaseDirectory, fileName);
    }

    public string GivenATempFile(string fileName)
    {
        return Path.Join(Path.GetTempPath(), fileName);
    }
}