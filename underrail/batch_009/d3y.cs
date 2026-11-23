using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x0200112A RID: 4394
[eiz("HELBJ")]
[Serializable]
public sealed class d3y : cze, ISerializable
{
	// Token: 0x06005E03 RID: 24067 RVA: 0x0027D838 File Offset: 0x0027BA38
	private d3y(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetBoolean("HELBJ:D");
			return;
		}
		if (base.GetType() == typeof(d3y))
		{
			this.a = A_0.GetBoolean("_Despawn");
			return;
		}
		this.a = A_0.GetBoolean("HandleEmptyLootBagJob+_Despawn");
	}

	// Token: 0x06005E04 RID: 24068 RVA: 0x0027D8A8 File Offset: 0x0027BAA8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("HELBJ:D", this.a);
	}

	// Token: 0x06005E05 RID: 24069 RVA: 0x0027D8C4 File Offset: 0x0027BAC4
	public bool a()
	{
		return this.a;
	}

	// Token: 0x06005E06 RID: 24070 RVA: 0x0027D8CC File Offset: 0x0027BACC
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005E07 RID: 24071 RVA: 0x0027D8D8 File Offset: 0x0027BAD8
	public d3y()
	{
	}

	// Token: 0x06005E08 RID: 24072 RVA: 0x0027D8E4 File Offset: 0x0027BAE4
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null && c5x.Zone != null)
		{
			c7j c7j = c5x.GetAspect<bim>() as c7j;
			if (c7j != null && (c7j.ItemContainer == null || c7j.ItemContainer.z2() == null || c7j.ItemContainer.z2().Count == 0))
			{
				c5x.RemoveAspect<bim>();
				if (this.a)
				{
					e4o e4o = new e4o(c5x);
					e4o.a((c5x.ae != null) ? ((byte)(Math.Min(1f, c5x.ae.Value) * 255f)) : byte.MaxValue);
					e4o.b(0);
					qy qy = new qy();
					qy.b(false);
					qy.c(false);
					qy.ad().Add(e4o);
					qy.ad().Add(new c7(A_1, false, false, true, false));
					c5x.Zone.ActionManager.g9(qy, atp.a);
				}
			}
		}
	}

	// Token: 0x04002567 RID: 9575
	private new bool a;
}
