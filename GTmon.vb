﻿<?xml version="1.0" encoding="UTF-8"?>
<VSPerformanceSession Version="1.00">
  <Options>
    <Solution>C:\Users\RA\Documents\Visual Studio 2010\Projects\GT Browser\GT Browser.sln</Solution>
    <CollectionMethod>Sampling</CollectionMethod>
    <AllocationMethod>Allocation</AllocationMethod>
    <LaunchRuntimeControl>true</LaunchRuntimeControl>
    <AddReport>true</AddReport>
    <ResourceBasedAnalysisSelected>false</ResourceBasedAnalysisSelected>
    <ThreadBasedAnalysisSelected>false</ThreadBasedAnalysisSelected>
    <UniqueReport>Timestamp</UniqueReport>
    <SamplingMethod>Cycles</SamplingMethod>
    <CycleCount>10000000</CycleCount>
    <PageFaultCount>10</PageFaultCount>
    <SysCallCount>10</SysCallCount>
    <SamplingCounter Name="" ReloadValue="00000000000f4240" DisplayName="" />
    <RelocateBinaries>false</RelocateBinaries>
    <CollectOnHpcCluster>false</CollectOnHpcCluster>
    <HPCSettings>
      <NumberOfProcesses>0</NumberOfProcesses>
      <TargetSelection>UnknownDisabled</TargetSelection>
      <ProfileOnRank>0</ProfileOnRank>
      <AdvancedProperties>
        <Project>GT Browser</Project>
        <CleanUp>true</CleanUp>
        <MpiexecCommand>mpiexec.exe</MpiexecCommand>
        <DeployCRT>true</DeployCRT>
      </AdvancedProperties>
    </HPCSettings>
    <HardwareCounters EnableHWCounters="false" />
    <EtwSettings />
    <PdhSettings>
      <PdhCountersEnabled>false</PdhCountersEnabled>
      <PdhCountersRate>500</PdhCountersRate>
      <PdhCounters>
        <PdhCounter>\Memory\Pages/sec</PdhCounter>
        <PdhCounter>\PhysicalDisk(_Total)\Avg. Disk Queue Length</PdhCounter>
        <PdhCounter>\Processor(_Total)\% Processor Time</PdhCounter>
      </PdhCounters>
    </PdhSettings>
  </Options>
  <ExcludeSmallFuncs>true</ExcludeSmallFuncs>
  <JScriptProfilingEnabled>false</JScriptProfilingEnabled>
  <PreinstrumentEvent>
    <InstrEventExclude>false</InstrEventExclude>
  </PreinstrumentEvent>
  <PostinstrumentEvent>
    <InstrEventExclude>false</InstrEventExclude>
  </PostinstrumentEvent>
  <Binaries>
    <ProjBinary>
      <Path>C:\Users\RA\Documents\Visual Studio 2010\Projects\GT Browser\GT Browser\obj\x86\Debug\GT Browser.exe</Path>
      <ArgumentTimestamp>01/01/0001 00:00:00</ArgumentTimestamp>
      <Instrument>true</Instrument>
      <Sample>true</Sample>
      <ExternalWebsite>false</ExternalWebsite>
      <InteractionProfilingEnabled>false</InteractionProfilingEnabled>
      <IsLocalJavascript>false</IsLocalJavascript>
      <LaunchProject>true</LaunchProject>
      <OverrideProjectSettings>false</OverrideProjectSettings>
      <LaunchMethod>Executable</LaunchMethod>
      <ExecutablePath>C:\Users\RA\Documents\Visual Studio 2010\Projects\GT Browser\GT Browser\bin\Debug\GT Browser.exe</ExecutablePath>
      <StartupDirectory>C:\Users\RA\Documents\Visual Studio 2010\Projects\GT Browser\GT Browser\bin\Debug\</StartupDirectory>
      <Arguments />
      <NetAppHost>IIS</NetAppHost>
      <NetBrowser>InternetExplorer</NetBrowser>
      <ExcludeSmallFuncs>true</ExcludeSmallFuncs>
      <JScriptProfilingEnabled>false</JScriptProfilingEnabled>
      <PreinstrumentEvent>
        <InstrEventExclude>false</InstrEventExclude>
      </PreinstrumentEvent>
      <PostinstrumentEvent>
        <InstrEventExclude>false</InstrEventExclude>
      </PostinstrumentEvent>
      <ProjRef>{4CE09676-44E9-4EE6-A7F1-C0621866FC76}|GT Browser\GT Browser.vbproj</ProjRef>
      <ProjPath>C:\Users\RA\Documents\Visual Studio 2010\Projects\GT Browser\GT Browser\GT Browser.vbproj</ProjPath>
      <ProjName>GT Browser</ProjName>
    </ProjBinary>
  </Binaries>
  <Launches>
    <ProjBinary>
      <Path>:PB:{4CE09676-44E9-4EE6-A7F1-C0621866FC76}|GT Browser\GT Browser.vbproj</Path>
    </ProjBinary>
  </Launches>
  <RuntimeMarks>
    <MarkName>Mark One</MarkName>
    <MarkName>Mark Two</MarkName>
    <MarkName>Mark Three</MarkName>
    <MarkName>Mark Four</MarkName>
    <MarkName>Mark Five</MarkName>
    <MarkName>Mark Six</MarkName>
    <MarkName>Mark Seven</MarkName>
    <MarkName>Mark Eight</MarkName>
    <MarkName>Mark Nine</MarkName>
    <MarkName>Mark Ten</MarkName>
  </RuntimeMarks>
</VSPerformanceSession>