using System;
using System.Runtime.Serialization;

// Token: 0x02001442 RID: 5186
[eiz("NACB2")]
[Serializable]
public sealed class cfk : bvd, ISerializable
{
	// Token: 0x0600749E RID: 29854 RVA: 0x00317674 File Offset: 0x00315874
	private cfk(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = (A_0.GetValue("NACB2:M", typeof(enp)) as enp);
		this.b = (A_0.GetValue("NACB2:I", typeof(enp)) as enp);
	}

	// Token: 0x0600749F RID: 29855 RVA: 0x003176C8 File Offset: 0x003158C8
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("NACB2:M", this.a);
		info.AddValue("NACB2:I", this.b);
	}

	// Token: 0x060074A0 RID: 29856 RVA: 0x003176EC File Offset: 0x003158EC
	public cfk(bvd A_0, bvd A_1)
	{
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x060074A1 RID: 29857 RVA: 0x00317704 File Offset: 0x00315904
	public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
	{
		this.mm(A_0, A_1, A_2, A_3, new bps());
	}

	// Token: 0x060074A2 RID: 29858 RVA: 0x00317718 File Offset: 0x00315918
	public void mm(amc A_0, amc A_1, cwt A_2, cru A_3, bps A_4)
	{
		if (this.a != null)
		{
			bvd bvd = this.a as bvd;
			if (bvd != null)
			{
				bvd.mm(A_0, A_1, A_2, A_3, A_4);
			}
			else
			{
				this.a.af(A_0, A_1, A_2, A_3);
			}
		}
		if (this.b != null)
		{
			bvd bvd2 = this.b as bvd;
			if (bvd2 != null)
			{
				bvd2.mm(A_0, A_1, A_2, A_3, A_4);
				return;
			}
			this.b.af(A_0, A_1, A_2, A_3);
		}
	}

	// Token: 0x04002FA5 RID: 12197
	private enp a;

	// Token: 0x04002FA6 RID: 12198
	private enp b;
}
