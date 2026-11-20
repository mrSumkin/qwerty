using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Ouroboros.Common.Data;

// Token: 0x020010B9 RID: 4281
[eiz("PSRJ")]
[Serializable]
public sealed class axw : cze
{
	// Token: 0x060059FF RID: 23039 RVA: 0x0026DB90 File Offset: 0x0026BD90
	private axw(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06005A00 RID: 23040 RVA: 0x0026DB9C File Offset: 0x0026BD9C
	public axw()
	{
	}

	// Token: 0x06005A01 RID: 23041 RVA: 0x0026DBA8 File Offset: 0x0026BDA8
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null)
		{
			a3f aspect = c5x.GetAspect<a3f>();
			if (aspect != null)
			{
				foreach (Property property in Enumerable.ToList<Property>(aspect.a().Properties))
				{
					Guid a_;
					if (property.Value is int && Guid.TryParse(property.Name, out a_))
					{
						int num = (int)property.Value - 1;
						if (num <= 0)
						{
							aspect.a().RemoveProperty(property.Name);
							c5x c5x2 = new ar7(a_, c5x.Area).ao() as c5x;
							if (c5x2 != null)
							{
								axh aspect2 = c5x2.GetAspect<axh>();
								if (aspect2 != null)
								{
									aspect2.a(null, true, null);
								}
							}
						}
						else
						{
							property.Value = num;
						}
					}
				}
			}
		}
	}
}
