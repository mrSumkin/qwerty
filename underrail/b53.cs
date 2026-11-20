using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x0200117F RID: 4479
[eiz("SEP")]
[Serializable]
public sealed class b53 : ISerializable
{
	// Token: 0x06005FA8 RID: 24488 RVA: 0x0029B020 File Offset: 0x00299220
	private b53(SerializationInfo A_0, StreamingContext A_1)
	{
		this.c = (qp)A_0.GetValue("SEP:ST", typeof(qp));
		this.b = (A_0.GetValue("SEP:S", typeof(List<string>)) as List<string>);
	}

	// Token: 0x06005FA9 RID: 24489 RVA: 0x0029B080 File Offset: 0x00299280
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue("SEP:ST", this.c);
		info.AddValue("SEP:S", this.b);
	}

	// Token: 0x06005FAA RID: 24490 RVA: 0x0029B0AC File Offset: 0x002992AC
	public qp d()
	{
		return this.c;
	}

	// Token: 0x06005FAB RID: 24491 RVA: 0x0029B0B4 File Offset: 0x002992B4
	public void a(qp A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005FAC RID: 24492 RVA: 0x0029B0C0 File Offset: 0x002992C0
	public List<string> b()
	{
		return this.b;
	}

	// Token: 0x06005FAD RID: 24493 RVA: 0x0029B0C8 File Offset: 0x002992C8
	public void a(List<string> A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005FAE RID: 24494 RVA: 0x0029B0D4 File Offset: 0x002992D4
	public b53()
	{
	}

	// Token: 0x06005FAF RID: 24495 RVA: 0x0029B0E8 File Offset: 0x002992E8
	public b53 a()
	{
		return new b53
		{
			b = ((this.b != null) ? new List<string>(this.b) : null),
			c = this.c
		};
	}

	// Token: 0x06005FB0 RID: 24496 RVA: 0x0029B120 File Offset: 0x00299320
	public List<string> c()
	{
		if (this.c == qp.b)
		{
			return new List<string>
			{
				this.b[b53.a.Next(this.b.Count)]
			};
		}
		return new List<string>(this.b);
	}

	// Token: 0x04002814 RID: 10260
	private static Random a = new Random();

	// Token: 0x04002815 RID: 10261
	private List<string> b = new List<string>();

	// Token: 0x04002816 RID: 10262
	private qp c;
}
