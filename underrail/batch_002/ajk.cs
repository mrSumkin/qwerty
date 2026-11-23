using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x0200065A RID: 1626
[eiz("XP0")]
[Serializable]
public sealed class ajk : ISerializable
{
	// Token: 0x06002942 RID: 10562 RVA: 0x000EB440 File Offset: 0x000E9640
	private ajk(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = (A_0.GetValue("XP0:C", typeof(e3q)) as e3q);
		this.b = (A_0.GetValue("XP0:V", typeof(Version)) as Version);
		this.c = (DateTime)A_0.GetValue("XP0:D", typeof(DateTime));
		this.d = (A_0.GetValue("XP0:B", typeof(bau)) as bau);
		if (ell.a() >= 333)
		{
			di7.ReadList<string>("XP0:L", ref this.e, A_0);
			return;
		}
		this.e = new List<string>();
	}

	// Token: 0x06002943 RID: 10563 RVA: 0x000EB50C File Offset: 0x000E970C
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("XP0:C", this.a);
		info.AddValue("XP0:V", this.b);
		info.AddValue("XP0:D", this.c);
		info.AddValue("XP0:B", this.d);
		di7.WriteList<string>("XP0:L", this.e, info);
	}

	// Token: 0x06002944 RID: 10564 RVA: 0x000EB570 File Offset: 0x000E9770
	public ajk()
	{
	}

	// Token: 0x06002945 RID: 10565 RVA: 0x000EB584 File Offset: 0x000E9784
	public void b(string A_0)
	{
		czh.a(A_0, "filePath");
		eoq.SerializeToBinaryFileCompressed<ajk>(A_0, this, dds.a(), eh9.c, true);
	}

	// Token: 0x06002946 RID: 10566 RVA: 0x000EB5A4 File Offset: 0x000E97A4
	public static ajk a(string A_0)
	{
		czh.a(A_0, "filePath");
		return eoq.DeserializeFromBinaryFileCompressed<ajk>(A_0, dds.a(), true);
	}

	// Token: 0x0400168E RID: 5774
	public e3q a;

	// Token: 0x0400168F RID: 5775
	public Version b;

	// Token: 0x04001690 RID: 5776
	public DateTime c;

	// Token: 0x04001691 RID: 5777
	public bau d;

	// Token: 0x04001692 RID: 5778
	public List<string> e = new List<string>();
}
