using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObfuscationAttributes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ModuleDefMD publicmodule;
        public void confuserex()
        {
            //ConfusedByAttribute
            TypeRef attrRef1 = publicmodule.CorLibTypes.GetTypeRef("System", "Attribute");
            var attrType1 = new TypeDefUser("", "ConfusedByAttribute", attrRef1);
            publicmodule.Types.Add(attrType1);
            /*
            var ctor1 = new MethodDefUser(".ctor", MethodSig.CreateInstance(publicmodule.CorLibTypes.Void, publicmodule.CorLibTypes.String), MethodImplAttributes.Managed, MethodAttributes.HideBySig | MethodAttributes.Public | MethodAttributes.SpecialName | MethodAttributes.RTSpecialName);
            ctor1.Body = new CilBody();
            ctor1.Body.MaxStack = 1;
            ctor1.Body.Instructions.Add(OpCodes.Ldarg_0.ToInstruction());
            ctor1.Body.Instructions.Add(OpCodes.Call.ToInstruction(new MemberRefUser(publicmodule, ".ctor", MethodSig.CreateInstance(publicmodule.CorLibTypes.Void), attrRef1)));
            ctor1.Body.Instructions.Add(OpCodes.Ret.ToInstruction());
            attrType1.Methods.Add(ctor1);
            */
        }
        public void babel()
        {
            TypeRef attrRef1 = publicmodule.CorLibTypes.GetTypeRef("System", "Attribute");
            var attrType1 = new TypeDefUser("", "BabelObfuscatorAttribute", attrRef1);
            publicmodule.Types.Add(attrType1);

            var ctor1 = new MethodDefUser(".ctor", MethodSig.CreateInstance(publicmodule.CorLibTypes.Void, publicmodule.CorLibTypes.String), MethodImplAttributes.Managed, MethodAttributes.HideBySig | MethodAttributes.Public | MethodAttributes.SpecialName | MethodAttributes.RTSpecialName);
            ctor1.Body = new CilBody();
            ctor1.Body.MaxStack = 1;
            ctor1.Body.Instructions.Add(OpCodes.Ldarg_0.ToInstruction());
            ctor1.Body.Instructions.Add(OpCodes.Call.ToInstruction(new MemberRefUser(publicmodule, ".ctor", MethodSig.CreateInstance(publicmodule.CorLibTypes.Void), attrRef1)));
            ctor1.Body.Instructions.Add(OpCodes.Ret.ToInstruction());
            attrType1.Methods.Add(ctor1);
        }
        public void dotfuscator()
        {
            TypeRef attrRef1 = publicmodule.CorLibTypes.GetTypeRef("System", "Attribute");
            var attrType1 = new TypeDefUser("", "DotfuscatorAttribute", attrRef1);
            publicmodule.Types.Add(attrType1);

            var ctor1 = new MethodDefUser(".ctor", MethodSig.CreateInstance(publicmodule.CorLibTypes.Void, publicmodule.CorLibTypes.String), MethodImplAttributes.Managed, MethodAttributes.HideBySig | MethodAttributes.Public | MethodAttributes.SpecialName | MethodAttributes.RTSpecialName);
            ctor1.Body = new CilBody();
            ctor1.Body.MaxStack = 1;
            ctor1.Body.Instructions.Add(OpCodes.Ldarg_0.ToInstruction());
            ctor1.Body.Instructions.Add(OpCodes.Call.ToInstruction(new MemberRefUser(publicmodule, ".ctor", MethodSig.CreateInstance(publicmodule.CorLibTypes.Void), attrRef1)));
            ctor1.Body.Instructions.Add(OpCodes.Ret.ToInstruction());
            attrType1.Methods.Add(ctor1);
        }
        public void ninerays()
        {
            TypeRef attrRef1 = publicmodule.CorLibTypes.GetTypeRef("System", "Attribute");
            var attrType1 = new TypeDefUser("", "NineRays.Obfuscator.Evaluation", attrRef1);
            publicmodule.Types.Add(attrType1);

            var ctor1 = new MethodDefUser(".ctor", MethodSig.CreateInstance(publicmodule.CorLibTypes.Void, publicmodule.CorLibTypes.String), MethodImplAttributes.Managed, MethodAttributes.HideBySig | MethodAttributes.Public | MethodAttributes.SpecialName | MethodAttributes.RTSpecialName);
            ctor1.Body = new CilBody();
            ctor1.Body.MaxStack = 1;
            ctor1.Body.Instructions.Add(OpCodes.Ldarg_0.ToInstruction());
            ctor1.Body.Instructions.Add(OpCodes.Call.ToInstruction(new MemberRefUser(publicmodule, ".ctor", MethodSig.CreateInstance(publicmodule.CorLibTypes.Void), attrRef1)));
            ctor1.Body.Instructions.Add(OpCodes.Ret.ToInstruction());
            attrType1.Methods.Add(ctor1);
        }
        public void mango()
        {
            TypeRef attrRef1 = publicmodule.CorLibTypes.GetTypeRef("System", "Attribute");
            var attrType1 = new TypeDefUser("", "();\u0009", attrRef1);
            publicmodule.Types.Add(attrType1);

            var ctor1 = new MethodDefUser(".ctor", MethodSig.CreateInstance(publicmodule.CorLibTypes.Void, publicmodule.CorLibTypes.String), MethodImplAttributes.Managed, MethodAttributes.HideBySig | MethodAttributes.Public | MethodAttributes.SpecialName | MethodAttributes.RTSpecialName);
            ctor1.Body = new CilBody();
            ctor1.Body.MaxStack = 1;
            ctor1.Body.Instructions.Add(OpCodes.Ldarg_0.ToInstruction());
            ctor1.Body.Instructions.Add(OpCodes.Call.ToInstruction(new MemberRefUser(publicmodule, ".ctor", MethodSig.CreateInstance(publicmodule.CorLibTypes.Void), attrRef1)));
            ctor1.Body.Instructions.Add(OpCodes.Ret.ToInstruction());
            attrType1.Methods.Add(ctor1);
        }
        public void bithelmet()
        {
            TypeRef attrRef1 = publicmodule.CorLibTypes.GetTypeRef("System", "Attribute");
            var attrType1 = new TypeDefUser("", "EMyPID_8234_", attrRef1);
            publicmodule.Types.Add(attrType1);

            var ctor1 = new MethodDefUser(".ctor", MethodSig.CreateInstance(publicmodule.CorLibTypes.Void, publicmodule.CorLibTypes.String), MethodImplAttributes.Managed, MethodAttributes.HideBySig | MethodAttributes.Public | MethodAttributes.SpecialName | MethodAttributes.RTSpecialName);
            ctor1.Body = new CilBody();
            ctor1.Body.MaxStack = 1;
            ctor1.Body.Instructions.Add(OpCodes.Ldarg_0.ToInstruction());
            ctor1.Body.Instructions.Add(OpCodes.Call.ToInstruction(new MemberRefUser(publicmodule, ".ctor", MethodSig.CreateInstance(publicmodule.CorLibTypes.Void), attrRef1)));
            ctor1.Body.Instructions.Add(OpCodes.Ret.ToInstruction());
            attrType1.Methods.Add(ctor1);
        }
        public void crypto()
        {
            TypeRef attrRef1 = publicmodule.CorLibTypes.GetTypeRef("System", "Attribute");
            var attrType1 = new TypeDefUser("", "CryptoObfuscator.ProtectedWithCryptoObfuscatorAttribute", attrRef1);
            publicmodule.Types.Add(attrType1);

            var ctor1 = new MethodDefUser(".ctor", MethodSig.CreateInstance(publicmodule.CorLibTypes.Void, publicmodule.CorLibTypes.String), MethodImplAttributes.Managed, MethodAttributes.HideBySig | MethodAttributes.Public | MethodAttributes.SpecialName | MethodAttributes.RTSpecialName);
            ctor1.Body = new CilBody();
            ctor1.Body.MaxStack = 1;
            //    ctor1.Body.Instructions.Add(OpCodes.Ldarg_0.ToInstruction());
            //    ctor1.Body.Instructions.Add(OpCodes.Call.ToInstruction(new MemberRefUser(publicmodule, ".ctor", MethodSig.CreateInstance(publicmodule.CorLibTypes.Void), attrRef1)));
            //   ctor1.Body.Instructions.Add(OpCodes.Ret.ToInstruction());
            attrType1.Methods.Add(ctor1);
        }
        public void yano()
        {
            TypeRef attrRef1 = publicmodule.CorLibTypes.GetTypeRef("System", "Attribute");
            var attrType1 = new TypeDefUser("", "YanoAttribute", attrRef1);
            publicmodule.Types.Add(attrType1);

            var ctor1 = new MethodDefUser(".ctor", MethodSig.CreateInstance(publicmodule.CorLibTypes.Void, publicmodule.CorLibTypes.String), MethodImplAttributes.Managed, MethodAttributes.HideBySig | MethodAttributes.Public | MethodAttributes.SpecialName | MethodAttributes.RTSpecialName);
            ctor1.Body = new CilBody();
            ctor1.Body.MaxStack = 1;
            attrType1.Methods.Add(ctor1);
        }
        public void dnguard()
        {
            //
            TypeRef attrRef1 = publicmodule.CorLibTypes.GetTypeRef("System", "Attribute");
            var attrType1 = new TypeDefUser("", "ZYXDNGuarder", attrRef1);
            publicmodule.Types.Add(attrType1);

            var ctor1 = new MethodDefUser(".ctor", MethodSig.CreateInstance(publicmodule.CorLibTypes.Void, publicmodule.CorLibTypes.String), MethodImplAttributes.Managed, MethodAttributes.HideBySig | MethodAttributes.Public | MethodAttributes.SpecialName | MethodAttributes.RTSpecialName);
            ctor1.Body = new CilBody();
            ctor1.Body.MaxStack = 1;
            attrType1.Methods.Add(ctor1);
        }
        public void goliath()
        {

            TypeRef attrRef1 = publicmodule.CorLibTypes.GetTypeRef("System", "Attribute");
            var attrType1 = new TypeDefUser("", "ObfuscatedByGoliath", attrRef1);
            publicmodule.Types.Add(attrType1);

            var ctor1 = new MethodDefUser(".ctor", MethodSig.CreateInstance(publicmodule.CorLibTypes.Void, publicmodule.CorLibTypes.String), MethodImplAttributes.Managed, MethodAttributes.HideBySig | MethodAttributes.Public | MethodAttributes.SpecialName | MethodAttributes.RTSpecialName);
            ctor1.Body = new CilBody();
            ctor1.Body.MaxStack = 1;
            attrType1.Methods.Add(ctor1);
        }
        public void agile()
        {

            TypeRef attrRef1 = publicmodule.CorLibTypes.GetTypeRef("System", "Attribute");
            var attrType1 = new TypeDefUser("", "SecureTeam.Attributes.ObfuscatedByAgileDotNetAttribute", attrRef1);
            publicmodule.Types.Add(attrType1);

            var ctor1 = new MethodDefUser(".ctor", MethodSig.CreateInstance(publicmodule.CorLibTypes.Void, publicmodule.CorLibTypes.String), MethodImplAttributes.Managed, MethodAttributes.HideBySig | MethodAttributes.Public | MethodAttributes.SpecialName | MethodAttributes.RTSpecialName);
            ctor1.Body = new CilBody();
            ctor1.Body.MaxStack = 1;
            attrType1.Methods.Add(ctor1);
        }
        public void smartassembly()
        {

            TypeRef attrRef1 = publicmodule.CorLibTypes.GetTypeRef("System", "Attribute");
            var attrType1 = new TypeDefUser("", "SmartAssembly.Attributes.PoweredByAttribute", attrRef1);
            publicmodule.Types.Add(attrType1);

            var ctor1 = new MethodDefUser(".ctor", MethodSig.CreateInstance(publicmodule.CorLibTypes.Void, publicmodule.CorLibTypes.String), MethodImplAttributes.Managed, MethodAttributes.HideBySig | MethodAttributes.Public | MethodAttributes.SpecialName | MethodAttributes.RTSpecialName);
            ctor1.Body = new CilBody();
            ctor1.Body.MaxStack = 1;
            attrType1.Methods.Add(ctor1);
        }
        public void xenocode()
        {

            TypeRef attrRef1 = publicmodule.CorLibTypes.GetTypeRef("System", "Attribute");
            var attrType1 = new TypeDefUser("", "Xenocode.Client.Attributes.AssemblyAttributes.ProcessedByXenocode", attrRef1);
            publicmodule.Types.Add(attrType1);

            var ctor1 = new MethodDefUser(".ctor", MethodSig.CreateInstance(publicmodule.CorLibTypes.Void, publicmodule.CorLibTypes.String), MethodImplAttributes.Managed, MethodAttributes.HideBySig | MethodAttributes.Public | MethodAttributes.SpecialName | MethodAttributes.RTSpecialName);
            ctor1.Body = new CilBody();
            ctor1.Body.MaxStack = 1;
            attrType1.Methods.Add(ctor1);
        }
        public bool xeno_ = false;
        public bool smart_ = false;
        public bool agile_ = false;
        public bool goliath_ = false;
        public bool yano_ = false;
        public bool crypto_ = false;
        public bool confuserex_ = false;
        public bool babel_ = false;
        public bool dotfus_ = false;
        public bool nine_ = false;
        public bool bithelm_ = false;
        public bool mango_ = false;
        public bool dnguard_ = false;
        void Modify(ModuleDefMD module)
        {

            publicmodule = module;
            if (xeno_)
            {
                xenocode();
            }
            if (smart_)
            {
                smartassembly();
            }
            if (agile_)
            {
                agile();
            }
            if (goliath_)
            {
                goliath();
            }
            if (yano_)
            {
                yano();
            }
            if (crypto_)
            {
                crypto();
            }
            if (confuserex_)
            {
                confuserex();
            }
            if (babel_)
            {
                babel();
            }
            if (dotfus_)
            {
                dotfuscator();
            }
            if (nine_)
            {
                ninerays();
            }
            if (bithelm_)
            {
                bithelmet();
            }
            if (mango_)
            {
                mango();
            }
            if (dnguard_)
            {
                dnguard();
            }
            AssemblyDef ass = AssemblyDef.Load(textBox1.Text);
            saveFileDialog1.ShowDialog();

        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked == true) { xeno_ = true; } else { xeno_ = false; }

            if (checkBox2.Checked == true) { smart_ = true; } else { smart_ = false; }

            if (checkBox3.Checked == true) { agile_ = true; } else { agile_ = false; }

            if (checkBox4.Checked == true) { goliath_ = true; } else { goliath_ = false; }

            if (checkBox5.Checked == true) { yano_ = true; } else { yano_ = false; }

            if (checkBox6.Checked == true) { crypto_ = true; } else { crypto_ = false; }


            if (checkBox8.Checked == true) { confuserex_ = true; } else { confuserex_ = false; }

            if (checkBox7.Checked == true) { babel_ = true; } else { babel_ = false; }

            if (checkBox9.Checked == true) { dotfus_ = true; } else { dotfus_ = false; }

            if (checkBox10.Checked == true) { nine_ = true; } else { nine_ = false; }

            if (checkBox12.Checked == true) { bithelm_ = true; } else { bithelm_ = false; }

            if (checkBox11.Checked == true) { mango_ = true; } else { mango_ = false; }

            if (checkBox13.Checked == true) { dnguard_ = true; } else { dnguard_ = false; }
            Modify(ModuleDefMD.Load(textBox1.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                textBox1.Text = file;
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string name = saveFileDialog1.FileName;
            publicmodule.Write(name);
        }
    }
}
