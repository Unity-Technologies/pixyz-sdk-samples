file(GLOB_RECURSE source_files *.py)

source_group(TREE "${CMAKE_CURRENT_SOURCE_DIR}" FILES ${source_files})
add_custom_target(pxzui SOURCES ${source_files})
add_dependencies(pxzui pxz)

set_target_properties(pxzui PROPERTIES FOLDER "UI")