using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Common.Aspects;

// Token: 0x020012CA RID: 4810
[eiz("MPH")]
[Serializable]
public sealed class do6 : Aspect<c5x>, ISerializable
{
	// Token: 0x06006A34 RID: 27188 RVA: 0x002CC440 File Offset: 0x002CA640
	protected do6(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		di7.ReadList<cze>("MPH:D", ref this.a, A_0);
		this.b = A_0.GetBoolean("MPH:A");
	}

	// Token: 0x06006A35 RID: 27189 RVA: 0x002CC478 File Offset: 0x002CA678
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteList<cze>("MPH:D", this.a, info);
		info.AddValue("MPH:A", this.b);
	}

	// Token: 0x06006A36 RID: 27190 RVA: 0x002CC4A4 File Offset: 0x002CA6A4
	public List<cze> d()
	{
		return this.a;
	}

	// Token: 0x06006A37 RID: 27191 RVA: 0x002CC4AC File Offset: 0x002CA6AC
	public void a(List<cze> A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06006A38 RID: 27192 RVA: 0x002CC4B8 File Offset: 0x002CA6B8
	public bool b()
	{
		return this.b;
	}

	// Token: 0x06006A39 RID: 27193 RVA: 0x002CC4C0 File Offset: 0x002CA6C0
	public void a(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06006A3A RID: 27194 RVA: 0x002CC4CC File Offset: 0x002CA6CC
	public do6(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06006A3B RID: 27195 RVA: 0x002CC4E4 File Offset: 0x002CA6E4
	public void a()
	{
		foreach (cze cze in this.a)
		{
			cze.ym(base.a8(), base.a8(), null);
		}
		if (this.b)
		{
			base.a8().w();
			base.a8().an();
		}
	}

	// Token: 0x04002BA9 RID: 11177
	private List<cze> a = new List<cze>();

	// Token: 0x04002BAA RID: 11178
	private bool b;
}
