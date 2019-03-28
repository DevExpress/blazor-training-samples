using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.RenderTree;

namespace ParentCoordinated.Shared
{
  public abstract class ContainerChildElement<TParent> : ChildElement<TParent>
  {
    [Parameter]
    RenderFragment ChildContent { get; set; }

    protected virtual ElementType ContainerElementType => ElementType.Div;

    protected virtual void CreateRenderContent(RenderTreeBuilder builder)
    {
      builder.OpenElement(0, ContainerElementType.ToString().ToLower());
      builder.AddAttribute(1, "class", ContainerCssClass);
      builder.AddContent(2, ChildContent);
      builder.CloseElement();
    }

    protected abstract string ContainerCssClass { get; }

    public override RenderFragment RenderContent => CreateRenderContent;
  }
}
