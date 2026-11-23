using System;
using System.Runtime.Serialization;

// Token: 0x020007DD RID: 2013
[eiz("SQT")]
[Serializable]
public sealed class dce : cca, ISerializable
{
	// Token: 0x06003271 RID: 12913 RVA: 0x00139CEC File Offset: 0x00137EEC
	private dce(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = A_0.GetString("SQT:QN");
		this.a = A_0.GetBoolean("SQT:PE");
		this.c = (A_0.GetValue("SQT:QS", typeof(int?)) as int?);
	}

	// Token: 0x06003272 RID: 12914 RVA: 0x00139D50 File Offset: 0x00137F50
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SQT:QN", this.b);
		info.AddValue("SQT:PE", this.a);
		info.AddValue("SQT:QS", this.c);
	}

	// Token: 0x06003273 RID: 12915 RVA: 0x00139DA0 File Offset: 0x00137FA0
	public bool c()
	{
		return this.a;
	}

	// Token: 0x06003274 RID: 12916 RVA: 0x00139DA8 File Offset: 0x00137FA8
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06003275 RID: 12917 RVA: 0x00139DB4 File Offset: 0x00137FB4
	public string a()
	{
		return this.b;
	}

	// Token: 0x06003276 RID: 12918 RVA: 0x00139DBC File Offset: 0x00137FBC
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06003277 RID: 12919 RVA: 0x00139DC8 File Offset: 0x00137FC8
	public int? b()
	{
		return this.c;
	}

	// Token: 0x06003278 RID: 12920 RVA: 0x00139DD0 File Offset: 0x00137FD0
	public void a(int? A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06003279 RID: 12921 RVA: 0x00139DDC File Offset: 0x00137FDC
	public dce()
	{
	}

	// Token: 0x0600327A RID: 12922 RVA: 0x00139DEC File Offset: 0x00137FEC
	protected override void adf(c5x A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqz().atb(this.a(), this.a) && this.c != null)
		{
			string name = bp5.h(this.a());
			serviceOrThrow.aqu().r().SetPropertyValue(name, this.c.Value);
		}
	}

	// Token: 0x04001B01 RID: 6913
	private bool a = true;

	// Token: 0x04001B02 RID: 6914
	private string b;

	// Token: 0x04001B03 RID: 6915
	private int? c;
}
