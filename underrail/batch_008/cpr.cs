using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Generators;

// Token: 0x020006DB RID: 1755
[eiz("A50")]
[Serializable]
public abstract class cpr : y8, ISerializable
{
	// Token: 0x06002D11 RID: 11537 RVA: 0x00101AB0 File Offset: 0x000FFCB0
	protected cpr(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06002D12 RID: 11538 RVA: 0x00101ABC File Offset: 0x000FFCBC
	public cpr()
	{
	}

	// Token: 0x06002D13 RID: 11539 RVA: 0x00101AC8 File Offset: 0x000FFCC8
	protected sealed override List<coh> a2()
	{
		List<coh> list = new List<coh>();
		int a_ = base.i();
		c8d c8d = this.wx(a_);
		if (c8d != null)
		{
			list.Add(c8d);
		}
		return list;
	}

	// Token: 0x06002D14 RID: 11540
	protected abstract c8d wx(int A_0);

	// Token: 0x06002D15 RID: 11541 RVA: 0x00101AF8 File Offset: 0x000FFCF8
	protected fv a(string A_0, int A_1)
	{
		string text;
		if (A_0 != null)
		{
			text = A_0;
		}
		else
		{
			ItemPoolForQuality<string> itemPoolForQuality = new ItemPoolForQuality<string>(A_1);
			itemPoolForQuality.a("GalvanicVest", 30, int.MaxValue, 1);
			itemPoolForQuality.a("InsulatedVest", int.MinValue, 100, 1);
			text = itemPoolForQuality.a();
		}
		if (text != null)
		{
			return y8.a("Vest\\" + text, null);
		}
		return null;
	}
}
