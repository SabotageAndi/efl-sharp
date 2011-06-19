
EXTRA_DIST =  

# Warning: This is an automatically generated file, do not edit!

if ENABLE_DEBUG
ASSEMBLY_COMPILER_COMMAND = gmcs
ASSEMBLY_COMPILER_FLAGS =  -noconfig -codepage:utf8 -warn:4 -optimize- -debug "-define:DEBUG" "-keyfile:../efl-sharp.key"
ASSEMBLY = bin/Debug/libelementary-sharp.dll
ASSEMBLY_MDB = $(ASSEMBLY).mdb
COMPILE_TARGET = library
PROJECT_REFERENCES =  \
	../evas-sharp/bin/Debug/libevas-sharp.dll \
	../efl-sharp-common/bin/Debug/libefl-sharp-common.dll \
	../eina-sharp/bin/Debug/libeina-sharp.dll
BUILD_DIR = bin/Debug

LIBELEMENTARY_SHARP_DLL_MDB_SOURCE=bin/Debug/libelementary-sharp.dll.mdb
LIBELEMENTARY_SHARP_DLL_MDB=$(BUILD_DIR)/libelementary-sharp.dll.mdb
LIBEVAS_SHARP_DLL_SOURCE=../evas-sharp/bin/Debug/libevas-sharp.dll
LIBEFL_SHARP_COMMON_DLL_SOURCE=../efl-sharp-common/bin/Debug/libefl-sharp-common.dll
LIBEFL_SHARP_COMMON_DLL_MDB_SOURCE=../efl-sharp-common/bin/Debug/libefl-sharp-common.dll.mdb
LIBEFL_SHARP_COMMON_DLL_MDB=$(BUILD_DIR)/libefl-sharp-common.dll.mdb
LIBEVAS_SHARP_DLL_MDB_SOURCE=../evas-sharp/bin/Debug/libevas-sharp.dll.mdb
LIBEVAS_SHARP_DLL_MDB=$(BUILD_DIR)/libevas-sharp.dll.mdb
LIBEINA_SHARP_DLL_SOURCE=../eina-sharp/bin/Debug/libeina-sharp.dll
LIBEINA_SHARP_DLL_MDB_SOURCE=../eina-sharp/bin/Debug/libeina-sharp.dll.mdb
LIBEINA_SHARP_DLL_MDB=$(BUILD_DIR)/libeina-sharp.dll.mdb

endif

if ENABLE_RELEASE
ASSEMBLY_COMPILER_COMMAND = gmcs
ASSEMBLY_COMPILER_FLAGS =  -noconfig -codepage:utf8 -warn:4 -optimize- "-keyfile:../efl-sharp.key"
ASSEMBLY = bin/Release/libelementary-sharp.dll
ASSEMBLY_MDB = 
COMPILE_TARGET = library
PROJECT_REFERENCES =  \
	../evas-sharp/bin/Release/libevas-sharp.dll \
	../efl-sharp-common/bin/Release/libefl-sharp-common.dll \
	../eina-sharp/bin/Release/libeina-sharp.dll
BUILD_DIR = bin/Release

LIBELEMENTARY_SHARP_DLL_MDB=
LIBEVAS_SHARP_DLL_SOURCE=../evas-sharp/bin/Release/libevas-sharp.dll
LIBEFL_SHARP_COMMON_DLL_SOURCE=../efl-sharp-common/bin/Release/libefl-sharp-common.dll
LIBEFL_SHARP_COMMON_DLL_MDB=
LIBEVAS_SHARP_DLL_MDB=
LIBEINA_SHARP_DLL_SOURCE=../eina-sharp/bin/Release/libeina-sharp.dll
LIBEINA_SHARP_DLL_MDB=

endif

AL=al2
SATELLITE_ASSEMBLY_NAME=$(notdir $(basename $(ASSEMBLY))).resources.dll

PROGRAMFILES = \
	$(LIBELEMENTARY_SHARP_DLL_MDB) \
	$(LIBEVAS_SHARP_DLL) \
	$(LIBEFL_SHARP_COMMON_DLL) \
	$(LIBEFL_SHARP_COMMON_DLL_MDB) \
	$(LIBEVAS_SHARP_DLL_MDB) \
	$(LIBEINA_SHARP_DLL) \
	$(LIBEINA_SHARP_DLL_MDB)  

LINUX_PKGCONFIG = \
	$(ELEMENTARY_SHARP_PC)  


RESGEN=resgen2
	
all: $(ASSEMBLY) $(PROGRAMFILES) $(LINUX_PKGCONFIG) 

FILES =  \
	src/AnchorView.cs \
	src/AssemblyInfo.cs \
	src/Background.cs \
	src/Box.cs \
	src/Button.cs \
	src/Check.cs \
	src/Constants.cs \
	src/Elementary.cs \
	src/Entry.cs \
	src/Frame.cs \
	src/Hoversel.cs \
	src/Image.cs \
	src/Impl/AnchorViewImpl.cs \
	src/Impl/BackgroundImpl.cs \
	src/Impl/BoxImpl.cs \
	src/Impl/ButtonImpl.cs \
	src/Impl/CheckImpl.cs \
	src/Impl/ElementaryImpl.cs \
	src/Impl/EntryImpl.cs \
	src/Impl/FrameImpl.cs \
	src/Impl/HoverselImpl.cs \
	src/Impl/ImageImpl.cs \
	src/Impl/LabelImpl.cs \
	src/Impl/ListImpl.cs \
	src/Impl/ScrolledEntryImpl.cs \
	src/Impl/ToolbarImpl.cs \
	src/Impl/ToolbarItemImpl.cs \
	src/Impl/WindowImpl.cs \
	src/Label.cs \
	src/Library.cs \
	src/List.cs \
	src/ListItem.cs \
	src/ScrolledEntry.cs \
	src/Toolbar.cs \
	src/ToolbarItem.cs \
	src/WidgetItem.cs \
	src/Window.cs 

DATA_FILES = 

RESOURCES = 

EXTRAS = \
	src \
	src/Status.txt \
	../efl-sharp.key \
	elementary-sharp.pc.in 

REFERENCES =  \
	../efl-sharp-common/bin/Debug/libefl-sharp-common.dll \
	../eina-sharp/bin/Debug/libeina-sharp.dll \
	../evas-sharp/bin/Debug/libevas-sharp.dll \
	System

DLL_REFERENCES = 

CLEANFILES = $(PROGRAMFILES) $(LINUX_PKGCONFIG) 

include $(top_srcdir)/Makefile.include

LIBEVAS_SHARP_DLL = $(BUILD_DIR)/libevas-sharp.dll
LIBEFL_SHARP_COMMON_DLL = $(BUILD_DIR)/libefl-sharp-common.dll
LIBEINA_SHARP_DLL = $(BUILD_DIR)/libeina-sharp.dll
ELEMENTARY_SHARP_PC = $(BUILD_DIR)/elementary-sharp.pc

$(eval $(call emit-deploy-target,LIBEVAS_SHARP_DLL))
$(eval $(call emit-deploy-target,LIBEFL_SHARP_COMMON_DLL))
$(eval $(call emit-deploy-target,LIBEFL_SHARP_COMMON_DLL_MDB))
$(eval $(call emit-deploy-target,LIBEVAS_SHARP_DLL_MDB))
$(eval $(call emit-deploy-target,LIBEINA_SHARP_DLL))
$(eval $(call emit-deploy-target,LIBEINA_SHARP_DLL_MDB))
$(eval $(call emit-deploy-wrapper,ELEMENTARY_SHARP_PC,elementary-sharp.pc))


$(eval $(call emit_resgen_targets))
$(build_xamlg_list): %.xaml.g.cs: %.xaml
	xamlg '$<'

$(ASSEMBLY_MDB): $(ASSEMBLY)

$(ASSEMBLY): $(build_sources) $(build_resources) $(build_datafiles) $(DLL_REFERENCES) $(PROJECT_REFERENCES) $(build_xamlg_list) $(build_satellite_assembly_list)
	mkdir -p $(shell dirname $(ASSEMBLY))
	$(ASSEMBLY_COMPILER_COMMAND) $(ASSEMBLY_COMPILER_FLAGS) -out:$(ASSEMBLY) -target:$(COMPILE_TARGET) $(build_sources_embed) $(build_resources_embed) $(build_references_ref)
