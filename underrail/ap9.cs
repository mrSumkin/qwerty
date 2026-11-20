using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001DE2 RID: 7650
[eiz("CI1")]
[Serializable]
public sealed class ap9 : ISerializable
{
	// Token: 0x0600A940 RID: 43328 RVA: 0x003F025C File Offset: 0x003EE45C
	private ap9(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetString("CI1:N");
			this.b = A_0.GetString("CI1:FI");
			this.c = A_0.GetBoolean("CI1:P");
			this.d = (Guid)A_0.GetValue("CI1:U", typeof(Guid));
			if (ell.a() >= 22)
			{
				this.e = (elx)A_0.GetValue("CT1:T", typeof(elx));
			}
			if (ell.a() >= 152)
			{
				this.f = (Gender)A_0.GetValue("CT1:G", typeof(Gender));
			}
			if (ell.a() >= 171)
			{
				this.g = (d8o)A_0.GetValue("CT1:A", typeof(d8o));
			}
			if (ell.a() >= 206)
			{
				di7.ReadList<string>("CT1:F", ref this.h, A_0);
			}
			else
			{
				this.h = new List<string>();
			}
			if (ell.a() >= 366)
			{
				this.j = A_0.GetBoolean("CI1:D");
			}
			if (ell.a() >= 396)
			{
				di7.ReadDictionary<string, int>("CT1:S", ref this.i, A_0);
				return;
			}
			this.i = new Dictionary<string, int>();
			return;
		}
		else
		{
			if (base.GetType() == typeof(ap9))
			{
				this.a = A_0.GetString("Name");
				this.b = A_0.GetString("FactionId");
				this.c = A_0.GetBoolean("Passive");
				this.d = (Guid)A_0.GetValue("Uid", typeof(Guid));
				return;
			}
			this.a = A_0.GetString("CharacterInfo+Name");
			this.b = A_0.GetString("CharacterInfo+FactionId");
			this.c = A_0.GetBoolean("CharacterInfo+Passive");
			this.d = (Guid)A_0.GetValue("CharacterInfo+Uid", typeof(Guid));
			return;
		}
	}

	// Token: 0x0600A941 RID: 43329 RVA: 0x003F04AC File Offset: 0x003EE6AC
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("CI1:N", this.a);
		info.AddValue("CI1:FI", this.b);
		info.AddValue("CI1:P", this.c);
		info.AddValue("CI1:U", this.d);
		info.AddValue("CT1:T", this.e);
		info.AddValue("CT1:G", this.f);
		info.AddValue("CT1:A", this.g);
		info.AddValue("CI1:D", this.j);
		di7.WriteList<string>("CT1:F", this.h, info);
		di7.WriteDictionary<string, int>("CT1:S", this.i, info);
	}

	// Token: 0x0600A942 RID: 43330 RVA: 0x003F0578 File Offset: 0x003EE778
	public ap9()
	{
	}

	// Token: 0x0600A943 RID: 43331 RVA: 0x003F0598 File Offset: 0x003EE798
	public ap9(string A_0, string A_1 = null)
	{
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x0600A944 RID: 43332 RVA: 0x003F05C8 File Offset: 0x003EE7C8
	public ap9(efk A_0)
	{
		if (A_0 != null)
		{
			this.a = A_0.Name;
			this.b = A_0.FactionId;
			this.c = A_0.Passive;
			this.d = A_0.Uid;
			if (A_0.b(d8o.b | d8o.c))
			{
				this.f = A_0.Gender;
			}
			else
			{
				this.f = Gender.Genderless;
			}
			this.a(A_0);
			this.g = A_0.Attributes;
			foreach (ai8 ai in A_0.Feats)
			{
				string text = ai8.a(ai.GetType());
				if (!string.IsNullOrEmpty(text))
				{
					this.h.Add(text);
				}
			}
			foreach (KeyValuePair<string, f> keyValuePair in A_0.Specializations)
			{
				this.i[keyValuePair.Key] = keyValuePair.Value.ModifiedValue;
			}
			this.j = A_0.CustomProperties.GetPrimitivePropertyValue<bool>("IsPlayerCreatedDoppelganger", new bool?(false)).Value;
		}
	}

	// Token: 0x0600A945 RID: 43333 RVA: 0x003F0748 File Offset: 0x003EE948
	public override string ToString()
	{
		return this.a();
	}

	// Token: 0x0600A946 RID: 43334 RVA: 0x003F0750 File Offset: 0x003EE950
	public bool a(elx A_0)
	{
		return (this.e & A_0) == A_0;
	}

	// Token: 0x0600A947 RID: 43335 RVA: 0x003F0760 File Offset: 0x003EE960
	public ap9 b()
	{
		return new ap9
		{
			g = this.g,
			b = this.b,
			h = new List<string>(this.h),
			f = this.f,
			a = this.a,
			c = this.c,
			e = this.e,
			d = this.d,
			j = this.j,
			i = new Dictionary<string, int>(this.i)
		};
	}

	// Token: 0x0600A948 RID: 43336 RVA: 0x003F07F4 File Offset: 0x003EE9F4
	public int GetSpec<T>() where T : apq
	{
		apq specialization = ac8.GetSpecialization<T>();
		if (specialization != null)
		{
			int result;
			this.i.TryGetValue(specialization.e4(), out result);
			return result;
		}
		return 0;
	}

	// Token: 0x0600A949 RID: 43337 RVA: 0x003F0824 File Offset: 0x003EEA24
	private void a(efk A_0)
	{
		this.e = elx.a;
	}

	// Token: 0x0600A94A RID: 43338 RVA: 0x003F0830 File Offset: 0x003EEA30
	public string a()
	{
		if (aji.a == null)
		{
			return this.a;
		}
		string text = qv.b("EntityNames/" + this.a);
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return this.a;
	}

	// Token: 0x04003F5B RID: 16219
	public string a;

	// Token: 0x04003F5C RID: 16220
	public string b;

	// Token: 0x04003F5D RID: 16221
	public bool c;

	// Token: 0x04003F5E RID: 16222
	public Guid d;

	// Token: 0x04003F5F RID: 16223
	public elx e;

	// Token: 0x04003F60 RID: 16224
	public Gender f;

	// Token: 0x04003F61 RID: 16225
	public d8o g;

	// Token: 0x04003F62 RID: 16226
	public List<string> h = new List<string>();

	// Token: 0x04003F63 RID: 16227
	public Dictionary<string, int> i = new Dictionary<string, int>();

	// Token: 0x04003F64 RID: 16228
	public bool j;
}
