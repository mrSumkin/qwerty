using System;
using System.Runtime.Serialization;
using Ouroboros.Common.Data;
using Ouroboros.Playfield.References;

// Token: 0x02001454 RID: 5204
[eiz("PIS")]
[Serializable]
public sealed class e5y : cnm, ISerializable
{
	// Token: 0x06007517 RID: 29975 RVA: 0x0031A240 File Offset: 0x00318440
	private e5y(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = (A_0.GetValue("PIS:I", typeof(TypedObjectReference<efk>)) as TypedObjectReference<efk>);
		this.b = (A_0.GetValue("PIS:M", typeof(a3s)) as a3s);
	}

	// Token: 0x06007518 RID: 29976 RVA: 0x0031A294 File Offset: 0x00318494
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("PIS:I", this.a);
		info.AddValue("PIS:M", this.b);
	}

	// Token: 0x06007519 RID: 29977 RVA: 0x0031A2B8 File Offset: 0x003184B8
	public efk b8()
	{
		if (this.a != null)
		{
			return this.a.ao();
		}
		return null;
	}

	// Token: 0x0600751A RID: 29978 RVA: 0x0031A2D4 File Offset: 0x003184D4
	public object b9()
	{
		if (this.b != null)
		{
			return this.b.afk();
		}
		return null;
	}

	// Token: 0x0600751B RID: 29979 RVA: 0x0031A2F0 File Offset: 0x003184F0
	public object ca()
	{
		return this.c;
	}

	// Token: 0x0600751C RID: 29980 RVA: 0x0031A2FC File Offset: 0x003184FC
	public e5y(amc A_0, object A_1)
	{
		if (A_0 != null)
		{
			if (A_0.aa() is e3q)
			{
				this.a = new dsx();
			}
			else
			{
				this.a = new eru(new EntityAspectReference<amc, amc>(A_0));
			}
		}
		coh coh = A_1 as coh;
		if (coh != null)
		{
			this.b = new cuj(this.a, coh);
		}
	}

	// Token: 0x04002FF7 RID: 12279
	private TypedObjectReference<efk> a;

	// Token: 0x04002FF8 RID: 12280
	private a3s b;

	// Token: 0x04002FF9 RID: 12281
	[NonSerialized]
	private object c;
}
