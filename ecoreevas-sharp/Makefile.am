
EXTRA_DIST =  

# Warning: This is an automatically generated file, do not edit!

if ENABLE_DEBUG
ASSEMBLY_COMPILER_COMMAND = gmcs
ASSEMBLY_COMPILER_FLAGS =  -noconfig -codepage:utf8 -warn:4 -optimize- -debug "-define:DEBUG" "-keyfile:../efl-sharp.key"
ASSEMBLY = bin/Debug/libecoreevas-sharp.dll
ASSEMBLY_MDB = $(ASSEMBLY).mdb
COMPILE_TARGET = library
PROJECT_REFERENCES =  \
	../efl-sharp-common/bin/Debug/libefl-sharp-common.dll \
	../evas-sharp/bin/Debug/libevas-sharp.dll
BUILD_DIR = bin/Debug

LIBECOREEVAS_SHARP_DLL_MDB_SOURCE=bin/Debug/libecoreevas-sharp.dll.mdb
LIBECOREEVAS_SHARP_DLL_MDB=$(BUILD_DIR)/libecoreevas-sharp.dll.mdb
LIBEFL_SHARP_COMMON_DLL_SOURCE=../efl-sharp-common/bin/Debug/libefl-sharp-common.dll
LIBEFL_SHARP_COMMON_DLL_MDB_SOURCE=../efl-sharp-common/bin/Debug/libefl-sharp-common.dll.mdb
LIBEFL_SHARP_COMMON_DLL_MDB=$(BUILD_DIR)/libefl-sharp-common.dll.mdb
LIBEVAS_SHARP_DLL_SOURCE=../evas-sharp/bin/Debug/libevas-sharp.dll
LIBEVAS_SHARP_DLL_MDB_SOURCE=../evas-sharp/bin/Debug/libevas-sharp.dll.mdb
LIBEVAS_SHARP_DLL_MDB=$(BUILD_DIR)/libevas-sharp.dll.mdb

endif

if ENABLE_RELEASE
ASSEMBLY_COMPILER_COMMAND = gmcs
ASSEMBLY_COMPILER_FLAGS =  -noconfig -codepage:utf8 -warn:4 -optimize- "-keyfile:../efl-sharp.key"
ASSEMBLY = bin/Release/libecoreevas-sharp.dll
ASSEMBLY_MDB = 
COMPILE_TARGET = library
PROJECT_REFERENCES =  \
	../efl-sharp-common/bin/Release/libefl-sharp-common.dll \
	../evas-sharp/bin/Release/libevas-sharp.dll
BUILD_DIR = bin/Release

LIBECOREEVAS_SHARP_DLL_MDB=
LIBEFL_SHARP_COMMON_DLL_SOURCE=../efl-sharp-common/bin/Release/libefl-sharp-common.dll
LIBEFL_SHARP_COMMON_DLL_MDB=
LIBEVAS_SHARP_DLL_SOURCE=../evas-sharp/bin/Release/libevas-sharp.dll
LIBEVAS_SHARP_DLL_MDB=

endif

AL=al2
SATELLITE_ASSEMBLY_NAME=$(notdir $(basename $(ASSEMBLY))).resources.dll

PROGRAMFILES = \
	$(LIBECOREEVAS_SHARP_DLL_MDB) \
	$(LIBEFL_SHARP_COMMON_DLL) \
	$(LIBEFL_SHARP_COMMON_DLL_MDB) \
	$(LIBEVAS_SHARP_DLL) \
	$(LIBEVAS_SHARP_DLL_MDB)  

LINUX_PKGCONFIG = \
	$(ECOREEVAS_SHARP_PC)  


RESGEN=resgen2
	
all: $(ASSEMBLY) $(PROGRAMFILES) $(LINUX_PKGCONFIG) 

FILES =  \
	src/AssemblyInfo.cs \
	src/EcoreEvas.cs \
	src/Impl/EcoreEvasImpl.cs 

DATA_FILES = 

RESOURCES = 

EXTRAS = \
	src \
	../efl-sharp.key \
	ecoreevas-sharp.pc.in 

REFERENCES =  \
	../efl-sharp-common/bin/Debug/libefl-sharp-common.dll \
	../evas-sharp/bin/Debug/libevas-sharp.dll \
	System

DLL_REFERENCES = 

CLEANFILES = $(PROGRAMFILES) $(LINUX_PKGCONFIG) 

include $(top_srcdir)/Makefile.include

LIBEFL_SHARP_COMMON_DLL = $(BUILD_DIR)/libefl-sharp-common.dll
LIBEVAS_SHARP_DLL = $(BUILD_DIR)/libevas-sharp.dll
ECOREEVAS_SHARP_PC = $(BUILD_DIR)/ecoreevas-sharp.pc

$(eval $(call emit-deploy-target,LIBEFL_SHARP_COMMON_DLL))
$(eval $(call emit-deploy-target,LIBEFL_SHARP_COMMON_DLL_MDB))
$(eval $(call emit-deploy-target,LIBEVAS_SHARP_DLL))
$(eval $(call emit-deploy-target,LIBEVAS_SHARP_DLL_MDB))
$(eval $(call emit-deploy-wrapper,ECOREEVAS_SHARP_PC,ecoreevas-sharp.pc))


$(eval $(call emit_resgen_targets))
$(build_xamlg_list): %.xaml.g.cs: %.xaml
	xamlg '$<'

$(ASSEMBLY_MDB): $(ASSEMBLY)

$(ASSEMBLY): $(build_sources) $(build_resources) $(build_datafiles) $(DLL_REFERENCES) $(PROJECT_REFERENCES) $(build_xamlg_list) $(build_satellite_assembly_list)
	mkdir -p $(shell dirname $(ASSEMBLY))
	$(ASSEMBLY_COMPILER_COMMAND) $(ASSEMBLY_COMPILER_FLAGS) -out:$(ASSEMBLY) -target:$(COMPILE_TARGET) $(build_sources_embed) $(build_resources_embed) $(build_references_ref)
