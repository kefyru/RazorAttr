using System;
using System.ComponentModel;

namespace RazorAttr.Components
{

  /// <summary>
  /// Property defined as css style.<br/>
  /// Behaviour will be like for 'style' property
  /// </summary>
  [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
  public class CssStyleAttribute: Attribute
  {
    
  }

  /// <summary>
  /// Property defined as css class.<br/>
  /// Behaviour will be like for 'class' property
  /// </summary>
  [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
  public class CssClassAttribute: Attribute
  {
    
  }

}