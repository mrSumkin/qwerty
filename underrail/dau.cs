using System;
using System.IO;
using System.Runtime.Serialization;

// Token: 0x020007BE RID: 1982
[eiz("TBOXC")]
[Serializable]
public class dau : dnh, ISerializable
{
	// Token: 0x0600319C RID: 12700 RVA: 0x0012FDB8 File Offset: 0x0012DFB8
	protected dau(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("TBOXC:V");
	}

	// Token: 0x0600319D RID: 12701 RVA: 0x0012FDD4 File Offset: 0x0012DFD4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("TBOXC:V", this.a);
	}

	// Token: 0x0600319E RID: 12702 RVA: 0x0012FDF0 File Offset: 0x0012DFF0
	public int a()
	{
		return this.a;
	}

	// Token: 0x0600319F RID: 12703 RVA: 0x0012FDF8 File Offset: 0x0012DFF8
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060031A0 RID: 12704 RVA: 0x0012FE04 File Offset: 0x0012E004
	public dau()
	{
	}

	// Token: 0x060031A1 RID: 12705 RVA: 0x0012FE10 File Offset: 0x0012E010
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		return serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && this.a(serviceOrThrow.aqu().v()) >= this.a;
	}

	// Token: 0x060031A2 RID: 12706 RVA: 0x0012FE5C File Offset: 0x0012E05C
	private int a(e3q A_0)
	{
		int num = 0;
		string text = Path.Combine(bpo.GetServiceOrThrow<d67>().lf(), Path.Combine(d5x.ai, "Oddities"));
		if (Directory.Exists(text))
		{
			string[] files = Directory.GetFiles(text, "*.*", 1);
			for (int i = 0; i < files.Length; i++)
			{
				x2 x = new d48(ez2.CreateDefinitonProvider<x2>(Path.GetFileNameWithoutExtension(files[i]))).Definition as x2;
				if (x != null && x.a7().GetPrimitivePropertyValue<bool>("TrophyBeltItem", new bool?(false)).Value && A_0.a(x.a5()) > 0)
				{
					num++;
				}
			}
		}
		return num;
	}

	// Token: 0x04001AB7 RID: 6839
	private int a;
}
