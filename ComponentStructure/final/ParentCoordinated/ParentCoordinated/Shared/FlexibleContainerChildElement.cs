using Microsoft.AspNetCore.Components;

namespace ParentCoordinated.Shared
{
  public abstract class FlexibleContainerChildElement<TParent> : ContainerChildElement<TParent>
  {
    [Parameter]
    public virtual ElementType ElementType { get; set; } = ElementType.Div;

    protected override ElementType ContainerElementType => ElementType;
  }
}
