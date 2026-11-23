using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B1B RID: 2843
[eiz("XPBLRFTVK")]
[Serializable]
public sealed class bkg : cze, ISerializable
{
	// Token: 0x060041AE RID: 16814 RVA: 0x00195268 File Offset: 0x00193468
	private bkg(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("XPBLRFTVK:TN");
	}

	// Token: 0x060041AF RID: 16815 RVA: 0x00195284 File Offset: 0x00193484
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("XPBLRFTVK:TN", this.a);
	}

	// Token: 0x060041B0 RID: 16816 RVA: 0x001952A0 File Offset: 0x001934A0
	public int a()
	{
		return this.a;
	}

	// Token: 0x060041B1 RID: 16817 RVA: 0x001952A8 File Offset: 0x001934A8
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060041B2 RID: 16818 RVA: 0x001952B4 File Offset: 0x001934B4
	public bkg()
	{
	}

	// Token: 0x060041B3 RID: 16819 RVA: 0x001952C0 File Offset: 0x001934C0
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
		if (serviceOrThrow != null && c5x != null)
		{
			e5t e5t = new e5t();
			string classPropertyValue = serviceOrThrow.aqu().r().GetClassPropertyValue<string>("global_xpbl_encryptedKeypadCode");
			string classPropertyValue2 = serviceOrThrow.aqu().r().GetClassPropertyValue<string>("global_xpbl_encryptedKeypadCode_key");
			string text = serviceOrThrow.aqu().r().GetClassPropertyValue<string>("global_xpbl_encryptedText_intervalKey");
			text = text.Substring(14);
			List<string> list = new List<string>();
			string text2 = "";
			for (int i = 0; i < text.Length; i++)
			{
				if (!char.IsPunctuation(text[i]))
				{
					text2 += text[i].ToString();
				}
				else
				{
					list.Add(text2);
					text2 = "";
					i++;
				}
			}
			string b = e5t.a(classPropertyValue, classPropertyValue2, list);
			string text3 = serviceOrThrow.aqu().r().GetClassPropertyValue<string>("loc_xpbl_rf_lockerPasswordTyped");
			int num = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_xpbl_rf_locker_digitsTyped", new int?(0)).Value;
			bool flag = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_rf_locker_wrongCode", new bool?(false)).Value;
			bool flag2 = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_rf_locker_opened", new bool?(false)).Value;
			num++;
			if (text3 == " ")
			{
				text3 = "";
			}
			text3 += this.a.ToString();
			if (text3 == b)
			{
				awh awh = new awh();
				awh.b(c5x.Area.y8());
				awh.b(new Guid("43a52d25-7978-4bb6-956d-936d47bf237f"));
				awh.a(new Guid("3d2bbc03-b0f8-4a86-896e-209b8eda8518"));
				awh.a(bbo.b);
				awh.a(true);
				awh.ym(A_0, A_1, null);
				flag2 = true;
				serviceOrThrow.aqu().r()["loc_xpbl_rf_locker_opened"] = flag2;
				c5x c5x2 = new ar7(new Guid("c0aaa5bd-47ce-4156-9525-23726e443f34"), c5x.Area).ao() as c5x;
				if (c5x2 != null)
				{
					if (c5x2.s.b != null)
					{
						c5x2.s.b.g(false);
					}
					if (c5x2.p.b != null)
					{
						c5x2.p.b.a[1].b.X = 1;
					}
				}
			}
			else if (num >= 4)
			{
				flag = true;
				serviceOrThrow.aqu().r()["loc_xpbl_rf_locker_wrongCode"] = flag;
				num = 0;
				text3 = " ";
			}
			serviceOrThrow.aqu().r()["loc_xpbl_rf_lockerPasswordTyped"] = text3;
			serviceOrThrow.aqu().r()["loc_xpbl_rf_locker_digitsTyped"] = num;
		}
	}

	// Token: 0x04001C18 RID: 7192
	private new int a;
}
