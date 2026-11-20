using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02001090 RID: 4240
[eiz("RJJ")]
[Serializable]
public sealed class bt8 : cze, ISerializable
{
	// Token: 0x0600588E RID: 22670 RVA: 0x0026623C File Offset: 0x0026443C
	private bt8(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (Guid?)A_0.GetValue("RJJ:TID", typeof(Guid?));
		this.b = A_0.GetBoolean("RJJ:RAJ");
		di7.ReadList<int>("RJJ:JTRI", ref this.c, A_0);
	}

	// Token: 0x0600588F RID: 22671 RVA: 0x002662A0 File Offset: 0x002644A0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("RJJ:TID", this.a);
		info.AddValue("RJJ:RAJ", this.b);
		di7.WriteList<int>("RJJ:JTRI", this.c, info);
	}

	// Token: 0x06005890 RID: 22672 RVA: 0x002662F0 File Offset: 0x002644F0
	public Guid? c()
	{
		return this.a;
	}

	// Token: 0x06005891 RID: 22673 RVA: 0x002662F8 File Offset: 0x002644F8
	public void a(Guid? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005892 RID: 22674 RVA: 0x00266304 File Offset: 0x00264504
	public bool a()
	{
		return this.b;
	}

	// Token: 0x06005893 RID: 22675 RVA: 0x0026630C File Offset: 0x0026450C
	public void a(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005894 RID: 22676 RVA: 0x00266318 File Offset: 0x00264518
	public List<int> b()
	{
		return this.c;
	}

	// Token: 0x06005895 RID: 22677 RVA: 0x00266320 File Offset: 0x00264520
	public void a(List<int> A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005896 RID: 22678 RVA: 0x0026632C File Offset: 0x0026452C
	public bt8()
	{
	}

	// Token: 0x06005897 RID: 22679 RVA: 0x00266340 File Offset: 0x00264540
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		aud aud = null;
		if (this.a != null)
		{
			if (A_0 != null)
			{
				aud = A_0.Area;
			}
			if (aud == null && A_1 != null)
			{
				aud = A_1.Area;
			}
			if (aud != null)
			{
				c5x c5x = aud.a(this.a.Value) as c5x;
				if (c5x != null)
				{
					this.a(c5x);
				}
			}
			return;
		}
		c5x c5x2 = A_1 as c5x;
		if (c5x2 != null)
		{
			this.a(c5x2);
		}
	}

	// Token: 0x06005898 RID: 22680 RVA: 0x002663C0 File Offset: 0x002645C0
	public void a(c5x A_0)
	{
		bim aspect = A_0.GetAspect<bim>();
		if (aspect != null)
		{
			if (this.b)
			{
				aspect.s().Clear();
				return;
			}
			for (int i = this.c.Count - 1; i >= 0; i--)
			{
				if (Enumerable.ElementAtOrDefault<cze>(aspect.s(), this.c[i]) != null)
				{
					aspect.s().RemoveAt(this.c[i]);
				}
			}
		}
	}

	// Token: 0x040023AD RID: 9133
	private new Guid? a;

	// Token: 0x040023AE RID: 9134
	private bool b;

	// Token: 0x040023AF RID: 9135
	private List<int> c = new List<int>();
}
