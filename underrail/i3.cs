using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001FD0 RID: 8144
[eiz("ISD")]
[Serializable]
public sealed class i3 : ISerializable
{
	// Token: 0x0600BF4A RID: 48970 RVA: 0x0042334C File Offset: 0x0042154C
	private i3(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			di7.ReadList<bj8>("ISD:I", ref this.a, A_0);
			return;
		}
		if (base.GetType() == typeof(i3))
		{
			this.a = (List<bj8>)A_0.GetValue("_Icons", typeof(List<bj8>));
			return;
		}
		this.a = (List<bj8>)A_0.GetValue("IconSetDescription+_Icons", typeof(List<bj8>));
	}

	// Token: 0x0600BF4B RID: 48971 RVA: 0x004233E4 File Offset: 0x004215E4
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		di7.WriteList<bj8>("ISD:I", this.a, info);
	}

	// Token: 0x0600BF4C RID: 48972 RVA: 0x004233F8 File Offset: 0x004215F8
	public List<bj8> a()
	{
		return this.a;
	}

	// Token: 0x0600BF4D RID: 48973 RVA: 0x00423400 File Offset: 0x00421600
	public void a(List<bj8> A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600BF4E RID: 48974 RVA: 0x0042340C File Offset: 0x0042160C
	public i3()
	{
	}

	// Token: 0x040044C3 RID: 17603
	private List<bj8> a = new List<bj8>();
}
