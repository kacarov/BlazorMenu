# BlazorMenu

This repository contains the implementation of a dynamic and infinitely nestable menu system using the Blazor framework. The menu supports top-level (root) and child items, and allows for flexible nesting of items with smooth mouse-driven interactions.

## Implementation Overview

The **BlazorMenu** project has been implemented in two separate projects:

- **BlazorMenuComponent**: A Razor Class Library containing the core functionality of the menu component.
- **BlazorMenuSampleApp**: A standalone Blazor app demonstrating the usage of the `BlazorMenuComponent` in different scenarios.

### Requirements Implemented

1. **Menu Structure**:  
   The menu supports top-level (root) and child items. A root item may or may not have sub-items. Child items can be nested infinitely, with each level appearing as a submenu.

   Example:
   - **Item 1** (top-level item)
   - **Item 1.1** (child of Item 1)
   - **Item 1.2** (child of Item 1)
     - **Item 1.2.1** (child of Item 1.2)

2. **Infinite Nesting**:  
   The menu allows infinite nesting of submenus at any level, and this functionality is fully implemented.

3. **Mouse Hover Interaction**:  
   Submenus are displayed when hovering over a menu item. For example, hovering over "Item 1" will display its submenus ("Item 1.1", "Item 1.2").  
   Submenus on higher levels (2nd, 3rd, etc.) are displayed to the right of their parent items, and this behavior is already implemented.

4. **Automatic Closing**:  
   Submenus close automatically when the mouse pointer moves outside of the submenu. This is also fully implemented.

## Approach Explanation

The project uses the **Blazor framework** to implement the menu component, as per the task's requirements. Here’s the reasoning behind the approach:

- **Blazor Framework**: The decision to use Blazor is driven by its seamless integration with .NET technologies and its ability to provide rich, interactive UI components in a web-based application. Blazor’s support for components and its efficient rendering model makes it ideal for building a dynamic menu system.
  
- **Component Structure**: The menu component is structured as a Razor Class Library (RCL), which makes it easily reusable and maintainable. The `BlazorMenuComponent` project encapsulates all the logic for rendering the menu, while the `BlazorMenuSampleApp` project demonstrates its usage in different scenarios.

- **Nested Menu**: Implementing infinite nesting was achieved by using a recursive component structure, where each menu item can contain another menu, thus supporting any level of depth.

- **Hover Interactions**: The hover-based submenu interaction is implemented using Blazor's event handling system, ensuring smooth transitions between menu items and submenus. CSS transitions and event triggers were used to manage the opening and closing of submenus.

- **Auto-Close**: The auto-close functionality was implemented using a simple event listener for mouse movement. When the mouse leaves a submenu, it triggers an event to close the submenu, providing a smooth user experience.
