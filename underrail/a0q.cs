using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x0200109A RID: 4250
[eiz("TSHSJ")]
[Serializable]
public sealed class a0q : cze
{
	// Token: 0x0600591B RID: 22811 RVA: 0x0026915C File Offset: 0x0026735C
	private a0q(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		di7.ReadList<Guid>("TSHSJ:E", ref this.a, A_0);
	}

	// Token: 0x0600591C RID: 22812 RVA: 0x00269184 File Offset: 0x00267384
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteList<Guid>("TSHSJ:E", this.a, info);
	}

	// Token: 0x0600591D RID: 22813 RVA: 0x002691A0 File Offset: 0x002673A0
	public List<Guid> a()
	{
		return this.a;
	}

	// Token: 0x0600591E RID: 22814 RVA: 0x002691A8 File Offset: 0x002673A8
	public void a(List<Guid> A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600591F RID: 22815 RVA: 0x002691B4 File Offset: 0x002673B4
	public a0q()
	{
	}

	// Token: 0x06005920 RID: 22816 RVA: 0x002691C8 File Offset: 0x002673C8
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		aud aud = null;
		if (A_0 != null)
		{
			aud = A_0.Area;
		}
		else if (A_1 != null)
		{
			aud = A_1.Area;
		}
		if (aud != null)
		{
			foreach (Guid a_ in this.a)
			{
				c5x c5x = new ar7(a_, aud).ao() as c5x;
				if (c5x != null)
				{
					dpj aspect = c5x.GetAspect<dpj>();
					if (aspect != null)
					{
						aspect.d();
					}
				}
			}
		}
	}

	// Token: 0x040023DB RID: 9179
	private new List<Guid> a = new List<Guid>();
}
