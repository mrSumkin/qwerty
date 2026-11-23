using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;

// Token: 0x020018C1 RID: 6337
[eiz("F1")]
[Serializable]
public sealed class bqi : ISerializable
{
	// Token: 0x0600866F RID: 34415 RVA: 0x0037BB54 File Offset: 0x00379D54
	private bqi(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetString("F1:I");
			this.b = A_0.GetString("F1:N");
			this.c = (h)A_0.GetValue("F1:SL", typeof(h));
			if (ell.a() >= 638)
			{
				di7.ReadDictionary<string, cky>("F1:R", ref this.d, A_0);
			}
			else
			{
				di7.ReadDictionary<bqi, cky>("F1:R", ref this.e, A_0);
			}
			if (ell.a() >= 253)
			{
				this.f = A_0.GetBoolean("F1:F");
			}
			if (ell.a() >= 296)
			{
				this.g = (A_0.GetValue("F1:V", typeof(exw)) as exw);
			}
			else
			{
				this.g = new exw();
			}
			if (ell.a() >= 410)
			{
				this.h = A_0.GetBoolean("F1:T");
				return;
			}
			this.h = true;
			return;
		}
		else
		{
			if (base.GetType() == typeof(bqi))
			{
				this.a = A_0.GetString("_Id");
				this.b = A_0.GetString("_Name");
				this.c = (h)A_0.GetValue("_SupportLevel", typeof(h));
				return;
			}
			this.a = A_0.GetString("Faction+_Id");
			this.b = A_0.GetString("Faction+_Name");
			this.c = (h)A_0.GetValue("Faction+_SupportLevel", typeof(h));
			return;
		}
	}

	// Token: 0x06008670 RID: 34416 RVA: 0x0037BD24 File Offset: 0x00379F24
	public void f()
	{
		if (this.e != null)
		{
			this.d = new Dictionary<string, cky>();
			foreach (KeyValuePair<bqi, cky> keyValuePair in this.e)
			{
				this.d[keyValuePair.Key.e()] = keyValuePair.Value;
			}
		}
	}

	// Token: 0x06008671 RID: 34417 RVA: 0x0037BDAC File Offset: 0x00379FAC
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("F1:I", this.a);
		info.AddValue("F1:N", this.b);
		info.AddValue("F1:SL", this.c);
		info.AddValue("F1:F", this.f);
		info.AddValue("F1:V", this.g);
		di7.WriteDictionary<string, cky>("F1:R", this.d, info);
		info.AddValue("F1:T", this.h);
	}

	// Token: 0x06008672 RID: 34418 RVA: 0x0037BE38 File Offset: 0x0037A038
	public void a(BinaryWriter A_0)
	{
		A_0.Write(this.a);
		A_0.Write(this.b);
		A_0.Write((int)this.c);
		A_0.Write(this.f);
		this.g.a(A_0);
		A_0.Write(this.d.Count);
		foreach (KeyValuePair<string, cky> keyValuePair in this.d)
		{
			A_0.Write(keyValuePair.Key);
			A_0.Write((int)keyValuePair.Value.a);
			A_0.Write((int)((keyValuePair.Value.b != null) ? keyValuePair.Value.b.Value : ((h)(-1))));
		}
		A_0.Write(this.h);
	}

	// Token: 0x06008673 RID: 34419 RVA: 0x0037BF38 File Offset: 0x0037A138
	public static bqi a(BinaryReader A_0)
	{
		bqi bqi = new bqi();
		bqi.a = A_0.ReadString();
		bqi.b = A_0.ReadString();
		bqi.c = (h)A_0.ReadInt32();
		bqi.f = A_0.ReadBoolean();
		bqi.g = exw.a(A_0);
		int num = A_0.ReadInt32();
		bqi.d = new Dictionary<string, cky>(num);
		for (int i = 0; i < num; i++)
		{
			cky cky = new cky();
			string key = A_0.ReadString();
			cky.a = (h)A_0.ReadInt32();
			int num2 = A_0.ReadInt32();
			if (num2 >= 0)
			{
				cky.b = new h?((h)num2);
			}
			bqi.d[key] = cky;
		}
		bqi.h = A_0.ReadBoolean();
		return bqi;
	}

	// Token: 0x06008674 RID: 34420 RVA: 0x0037BFFC File Offset: 0x0037A1FC
	public string e()
	{
		return this.a;
	}

	// Token: 0x06008675 RID: 34421 RVA: 0x0037C004 File Offset: 0x0037A204
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008676 RID: 34422 RVA: 0x0037C010 File Offset: 0x0037A210
	public string c()
	{
		return this.b;
	}

	// Token: 0x06008677 RID: 34423 RVA: 0x0037C018 File Offset: 0x0037A218
	public void b(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06008678 RID: 34424 RVA: 0x0037C024 File Offset: 0x0037A224
	public h g()
	{
		return this.c;
	}

	// Token: 0x06008679 RID: 34425 RVA: 0x0037C02C File Offset: 0x0037A22C
	public void a(h A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600867A RID: 34426 RVA: 0x0037C038 File Offset: 0x0037A238
	public Dictionary<string, cky> d()
	{
		return this.d;
	}

	// Token: 0x0600867B RID: 34427 RVA: 0x0037C040 File Offset: 0x0037A240
	public bool a()
	{
		return this.f;
	}

	// Token: 0x0600867C RID: 34428 RVA: 0x0037C048 File Offset: 0x0037A248
	public void a(bool A_0)
	{
		this.f = A_0;
	}

	// Token: 0x0600867D RID: 34429 RVA: 0x0037C054 File Offset: 0x0037A254
	public exw b()
	{
		return this.g;
	}

	// Token: 0x0600867E RID: 34430 RVA: 0x0037C05C File Offset: 0x0037A25C
	public void a(exw A_0)
	{
		this.g = A_0;
	}

	// Token: 0x0600867F RID: 34431 RVA: 0x0037C068 File Offset: 0x0037A268
	public bool h()
	{
		return this.h;
	}

	// Token: 0x06008680 RID: 34432 RVA: 0x0037C070 File Offset: 0x0037A270
	public void b(bool A_0)
	{
		this.h = A_0;
	}

	// Token: 0x06008681 RID: 34433 RVA: 0x0037C07C File Offset: 0x0037A27C
	private bqi()
	{
	}

	// Token: 0x06008682 RID: 34434 RVA: 0x0037C098 File Offset: 0x0037A298
	public bqi(string A_0, string A_1)
	{
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x06008683 RID: 34435 RVA: 0x0037C0C0 File Offset: 0x0037A2C0
	public override string ToString()
	{
		return string.Format("[{0}] '{1}'", this.a, this.b);
	}

	// Token: 0x040033C2 RID: 13250
	private string a;

	// Token: 0x040033C3 RID: 13251
	private string b;

	// Token: 0x040033C4 RID: 13252
	private h c;

	// Token: 0x040033C5 RID: 13253
	private Dictionary<string, cky> d = new Dictionary<string, cky>();

	// Token: 0x040033C6 RID: 13254
	private Dictionary<bqi, cky> e;

	// Token: 0x040033C7 RID: 13255
	private bool f;

	// Token: 0x040033C8 RID: 13256
	private exw g;

	// Token: 0x040033C9 RID: 13257
	private bool h = true;
}
