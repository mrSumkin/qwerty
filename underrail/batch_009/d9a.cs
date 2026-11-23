using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000ADA RID: 2778
[eiz("XPBLSLSTPJ")]
[Serializable]
public sealed class d9a : cze, ISerializable
{
	// Token: 0x060040C0 RID: 16576 RVA: 0x0018ACC4 File Offset: 0x00188EC4
	private d9a(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("XPBLSLSTPJ:T");
	}

	// Token: 0x060040C1 RID: 16577 RVA: 0x0018ACE0 File Offset: 0x00188EE0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("XPBLSLSTPJ:T", this.a);
	}

	// Token: 0x060040C2 RID: 16578 RVA: 0x0018ACFC File Offset: 0x00188EFC
	public int a()
	{
		return this.a;
	}

	// Token: 0x060040C3 RID: 16579 RVA: 0x0018AD04 File Offset: 0x00188F04
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060040C4 RID: 16580 RVA: 0x0018AD10 File Offset: 0x00188F10
	public d9a()
	{
	}

	// Token: 0x060040C5 RID: 16581 RVA: 0x0018AD1C File Offset: 0x00188F1C
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		aud aud = cze.a(null, A_0, A_1, A_2);
		if (aud != null && aud.Zone != null)
		{
			d60 d = aud.Zone.a();
			if (d != null)
			{
				c5x c5x = d.ab5("subWindow") as c5x;
				if (c5x != null)
				{
					dzy aspect = c5x.GetAspect<dzy>();
					if (aspect != null)
					{
						aspect.a(this.a);
					}
				}
			}
		}
	}

	// Token: 0x04001C06 RID: 7174
	private new int a;
}
