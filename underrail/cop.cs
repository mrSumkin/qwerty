using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020007BC RID: 1980
[eiz("SGSAEA")]
[Serializable]
public sealed class cop : esc, ISerializable
{
	// Token: 0x0600318F RID: 12687 RVA: 0x0012FBE8 File Offset: 0x0012DDE8
	private cop(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("SGSAEA:C");
	}

	// Token: 0x06003190 RID: 12688 RVA: 0x0012FC04 File Offset: 0x0012DE04
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SGSAEA:C", this.a);
	}

	// Token: 0x06003191 RID: 12689 RVA: 0x0012FC20 File Offset: 0x0012DE20
	public string a()
	{
		return this.a;
	}

	// Token: 0x06003192 RID: 12690 RVA: 0x0012FC28 File Offset: 0x0012DE28
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06003193 RID: 12691 RVA: 0x0012FC34 File Offset: 0x0012DE34
	public override int d5(bq8 A_0, bq8 A_1)
	{
		if (!string.IsNullOrEmpty(this.a))
		{
			HashSet<string> hashSet = A_1.GetClassPropertyValue<HashSet<string>>("clueList");
			if (hashSet == null)
			{
				hashSet = new HashSet<string>();
				A_1.set_Item("clueList", hashSet);
			}
			hashSet.Add(this.a.ToUpperInvariant());
		}
		return 0;
	}

	// Token: 0x06003194 RID: 12692 RVA: 0x0012FC88 File Offset: 0x0012DE88
	public cop()
	{
	}

	// Token: 0x04001AB4 RID: 6836
	private string a;
}
